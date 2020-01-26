using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video.DirectShow;
using AForge.Video;
using Accord.Video.VFW;
using Accord.Video.FFMPEG;
using AForge.Imaging.Filters;


namespace USBCam
{
    public partial class MainWindow : Form
    {
        FilterInfoCollection videoDevicesList;
        VideoCaptureDevice camera;
        int brightess1 = 0;
        int contrast1 = 0;
        float saturation1 = 0;
        Size pictureBoxOriginalSize;
        double zoomValue = 0;
        bool isRecording = false;
        Bitmap previousBitmap;
        Bitmap actualBitmap;
        VideoFileWriter writer;
        bool isGenerating = false;

        public MainWindow()
        {
            InitializeComponent();
            pictureBoxOriginalSize = pbCam1.Size;
            nasycenie1TrackBar.Maximum = 100;
            nasycenie1TrackBar.Minimum = -100;
            zoomTrackBar.Maximum = 1000;
            zoomTrackBar.Minimum = 0;
        }

        private void button_searchDev_Click(object sender, EventArgs e)
        {
            videoDevicesList = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo videoDevice in videoDevicesList)
            {
                cmbDevList1.Items.Add(videoDevice.Name);
            }
        }

        private void CameraOne_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap1 = (Bitmap) eventArgs.Frame.Clone();
            BrightnessCorrection br = new BrightnessCorrection(brightess1);
            ContrastCorrection cr = new ContrastCorrection(contrast1);
            SaturationCorrection sr = new SaturationCorrection(saturation1/100);

            bitmap1 = br.Apply((Bitmap)bitmap1.Clone());
            bitmap1 = cr.Apply((Bitmap)bitmap1.Clone());
            bitmap1 = sr.Apply((Bitmap)bitmap1.Clone());

            if(camera.IsRunning && isGenerating)
            {
                Bitmap picture = (Bitmap)pbCam1.Image;
                picture.Save("img.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }

            if(pbCam1.Image != null && camera.IsRunning)
                previousBitmap = new Bitmap(pbCam1.Image);

            actualBitmap = (Bitmap)bitmap1.Clone();

            const double MaxScale = 5.0;
            double scale = (double)Math.Pow(MaxScale, zoomValue / zoomTrackBar.Maximum);
            Size newSize = new Size((int)(pictureBoxOriginalSize.Width * scale), (int)(pictureBoxOriginalSize.Height * scale));
            Bitmap resizedBitmap = new Bitmap(bitmap1, newSize);

            this.Invoke(new Action(() =>
            {
                pbCam1.Image = resizedBitmap;
            }));

            checkMovePercentage();

            if (isRecording)
            {
                try
                {
                    Bitmap currentFrame = (Bitmap)pbCam1.Image.Clone();
                    writer.WriteVideoFrame(currentFrame);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        private void checkMovePercentage()
        {
            if (previousBitmap != null)
            {
                List<bool> previousHash = GetHash(previousBitmap);
                List<bool> actualHash = GetHash(actualBitmap);

                int equalElements = previousHash.Zip(actualHash, (i, j) => i == j).Count(eq => eq);
                int difference = 256 - equalElements;
                float differencePercentage = (float)(Math.Round((double)difference / 256 * 100));

                this.Invoke(new Action(() =>
                {
                    if (differencePercentage > 20)
                        differenceLabel.ForeColor = System.Drawing.Color.Orange;
                    else if (differencePercentage > 40)
                        differenceLabel.ForeColor = System.Drawing.Color.Red;
                    else
                        differenceLabel.ForeColor = System.Drawing.Color.Black;

                    differenceLabel.Text = "Procent ruchu: " + differencePercentage + "%";

                }));
            }
        }

        private void buttonSsCam1_Click(object sender, EventArgs e)
        {
            if(cmbDevList1.SelectedIndex != -1)
            {
                buttonSsCam1.Enabled = false;
                camera = new VideoCaptureDevice(videoDevicesList[cmbDevList1.SelectedIndex].MonikerString);
                camera.NewFrame += new NewFrameEventHandler(CameraOne_NewFrame);
                camera.Start();
            }
        }

        private void buttonPictureCamOne_Click(object sender, EventArgs e)
        {
            Bitmap picture = (Bitmap) pbCam1.Image;
            saveFileDialog.Filter = "JPG Image|*.jpg";
            saveFileDialog.Title = "Save an Image File";
            saveFileDialog.ShowDialog();
            System.IO.FileStream fs = (System.IO.FileStream) saveFileDialog.OpenFile();
            picture.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
            fs.Close();
        }

        private List<bool> GetHash(Bitmap bmpSource)
        {
            List<bool> lResult = new List<bool>();
            Bitmap bmpMin = new Bitmap(bmpSource, new Size(16, 16));
            for (int i = 0; i < bmpMin.Height; i++)
            {
                for (int j = 0; j < bmpMin.Width; j++)
                {
                    lResult.Add(bmpMin.GetPixel(i, j).GetBrightness() < 0.5f);
                }
            }

            return lResult;
        }

        private void buttonRecordingCamOne_Click(object sender, EventArgs e)
        {
            if (camera.IsRunning)
            {
                buttonRecordingCamOne.Enabled = false;
                buttonStopRecording.Enabled = true;

                try
                {
                    isRecording = true; 
                    writer = new VideoFileWriter(); 
                    writer.Open("video.avi", pbCam1.Image.Width, pbCam1.Image.Height, 15, VideoCodec.Default);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                } 
            }
        }
        private void jasnosc1TrackBar_Scroll(object sender, EventArgs e)
        {
                if(camera.IsRunning)
                brightess1 = jasnosc1TrackBar.Value;

        }

        private void kontrast1TrackBar_Scroll(object sender, EventArgs e)
        {
                if(camera.IsRunning)
                contrast1 = kontrast1TrackBar.Value;
        }

        private void nasycenie1TrackBar_Scroll(object sender, EventArgs e)
        {
                if (camera.IsRunning)
                saturation1 = nasycenie1TrackBar.Value;
        }

        private void buttonStopRecording_Click(object sender, EventArgs e)
        {
            if (camera.IsRunning)
            {
                isRecording = false;
                writer.Close();

                buttonRecordingCamOne.Enabled = true;
                buttonStopRecording.Enabled = false;
            }
        }

        private void zoomTrackBar_Scroll(object sender, EventArgs e)
        {
            if (camera.IsRunning)
                zoomValue = zoomTrackBar.Value;
        }

        private void buttonGenerateHTML_Click(object sender, EventArgs e)
        {
            if (camera.IsRunning)
            {
                var path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
                Console.WriteLine(path);
                isGenerating = true;
                System.Diagnostics.Process.Start("firefox", path + "\\index.html");
                buttonGenerateHTML.Enabled = false;
                buttonStopGenerateHTML.Enabled = true;
            }
        }

        private void buttonStopGenerateHTML_Click(object sender, EventArgs e)
        {
            if (camera.IsRunning)
            {
                isGenerating = true;
                buttonGenerateHTML.Enabled = true;
                buttonStopGenerateHTML.Enabled = false;
            }
        }
    }
}