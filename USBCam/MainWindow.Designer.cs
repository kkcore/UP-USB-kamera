namespace USBCam
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_searchDev = new System.Windows.Forms.Button();
            this.cmbDevList1 = new System.Windows.Forms.ComboBox();
            this.pbCam1 = new System.Windows.Forms.PictureBox();
            this.labelCamera1 = new System.Windows.Forms.Label();
            this.buttonSsCam1 = new System.Windows.Forms.Button();
            this.buttonPictureCamOne = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonRecordingCamOne = new System.Windows.Forms.Button();
            this.buttonStopRecordingCamOne = new System.Windows.Forms.Button();
            this.brightness1label = new System.Windows.Forms.Label();
            this.saturation1label = new System.Windows.Forms.Label();
            this.contrast1label = new System.Windows.Forms.Label();
            this.jasnosc1TrackBar = new System.Windows.Forms.TrackBar();
            this.nasycenie1TrackBar = new System.Windows.Forms.TrackBar();
            this.kontrast1TrackBar = new System.Windows.Forms.TrackBar();
            this.buttonStopRecording = new System.Windows.Forms.Button();
            this.differenceLabel = new System.Windows.Forms.Label();
            this.zoomLabel = new System.Windows.Forms.Label();
            this.zoomTrackBar = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonGenerateHTML = new System.Windows.Forms.Button();
            this.buttonStopGenerateHTML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jasnosc1TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nasycenie1TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontrast1TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_searchDev
            // 
            this.button_searchDev.Location = new System.Drawing.Point(18, 12);
            this.button_searchDev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_searchDev.Name = "button_searchDev";
            this.button_searchDev.Size = new System.Drawing.Size(600, 35);
            this.button_searchDev.TabIndex = 0;
            this.button_searchDev.Text = "Szukaj urządzeń";
            this.button_searchDev.UseVisualStyleBackColor = true;
            this.button_searchDev.Click += new System.EventHandler(this.button_searchDev_Click);
            // 
            // cmbDevList1
            // 
            this.cmbDevList1.FormattingEnabled = true;
            this.cmbDevList1.Location = new System.Drawing.Point(18, 83);
            this.cmbDevList1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDevList1.Name = "cmbDevList1";
            this.cmbDevList1.Size = new System.Drawing.Size(592, 28);
            this.cmbDevList1.TabIndex = 1;
            // 
            // pbCam1
            // 
            this.pbCam1.Location = new System.Drawing.Point(4, 5);
            this.pbCam1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbCam1.Name = "pbCam1";
            this.pbCam1.Size = new System.Drawing.Size(582, 384);
            this.pbCam1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCam1.TabIndex = 3;
            this.pbCam1.TabStop = false;
            // 
            // labelCamera1
            // 
            this.labelCamera1.AutoSize = true;
            this.labelCamera1.Location = new System.Drawing.Point(18, 54);
            this.labelCamera1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCamera1.Name = "labelCamera1";
            this.labelCamera1.Size = new System.Drawing.Size(116, 20);
            this.labelCamera1.TabIndex = 4;
            this.labelCamera1.Text = "Nazwa kamery:";
            // 
            // buttonSsCam1
            // 
            this.buttonSsCam1.Location = new System.Drawing.Point(18, 551);
            this.buttonSsCam1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSsCam1.Name = "buttonSsCam1";
            this.buttonSsCam1.Size = new System.Drawing.Size(98, 35);
            this.buttonSsCam1.TabIndex = 7;
            this.buttonSsCam1.Text = "Start";
            this.buttonSsCam1.UseVisualStyleBackColor = true;
            this.buttonSsCam1.Click += new System.EventHandler(this.buttonSsCam1_Click);
            // 
            // buttonPictureCamOne
            // 
            this.buttonPictureCamOne.Location = new System.Drawing.Point(124, 551);
            this.buttonPictureCamOne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPictureCamOne.Name = "buttonPictureCamOne";
            this.buttonPictureCamOne.Size = new System.Drawing.Size(98, 35);
            this.buttonPictureCamOne.TabIndex = 11;
            this.buttonPictureCamOne.Text = "Zdjęcie";
            this.buttonPictureCamOne.UseVisualStyleBackColor = true;
            this.buttonPictureCamOne.Click += new System.EventHandler(this.buttonPictureCamOne_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "picture";
            // 
            // buttonRecordingCamOne
            // 
            this.buttonRecordingCamOne.Location = new System.Drawing.Point(231, 551);
            this.buttonRecordingCamOne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRecordingCamOne.Name = "buttonRecordingCamOne";
            this.buttonRecordingCamOne.Size = new System.Drawing.Size(186, 35);
            this.buttonRecordingCamOne.TabIndex = 13;
            this.buttonRecordingCamOne.Text = "Zacznij nagrywać";
            this.buttonRecordingCamOne.UseVisualStyleBackColor = true;
            this.buttonRecordingCamOne.Click += new System.EventHandler(this.buttonRecordingCamOne_Click);
            // 
            // buttonStopRecordingCamOne
            // 
            this.buttonStopRecordingCamOne.Enabled = false;
            this.buttonStopRecordingCamOne.Location = new System.Drawing.Point(225, 358);
            this.buttonStopRecordingCamOne.Name = "buttonStopRecordingCamOne";
            this.buttonStopRecordingCamOne.Size = new System.Drawing.Size(65, 23);
            this.buttonStopRecordingCamOne.TabIndex = 18;
            this.buttonStopRecordingCamOne.Text = "Stop";
            this.buttonStopRecordingCamOne.UseVisualStyleBackColor = true;
            // 
            // brightness1label
            // 
            this.brightness1label.AutoSize = true;
            this.brightness1label.Location = new System.Drawing.Point(18, 635);
            this.brightness1label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.brightness1label.Name = "brightness1label";
            this.brightness1label.Size = new System.Drawing.Size(68, 20);
            this.brightness1label.TabIndex = 15;
            this.brightness1label.Text = "Jasność";
            // 
            // saturation1label
            // 
            this.saturation1label.AutoSize = true;
            this.saturation1label.Location = new System.Drawing.Point(18, 715);
            this.saturation1label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.saturation1label.Name = "saturation1label";
            this.saturation1label.Size = new System.Drawing.Size(77, 20);
            this.saturation1label.TabIndex = 16;
            this.saturation1label.Text = "Saturacja";
            // 
            // contrast1label
            // 
            this.contrast1label.AutoSize = true;
            this.contrast1label.Location = new System.Drawing.Point(27, 791);
            this.contrast1label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contrast1label.Name = "contrast1label";
            this.contrast1label.Size = new System.Drawing.Size(69, 20);
            this.contrast1label.TabIndex = 17;
            this.contrast1label.Text = "Kontrast";
            // 
            // jasnosc1TrackBar
            // 
            this.jasnosc1TrackBar.Location = new System.Drawing.Point(124, 620);
            this.jasnosc1TrackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jasnosc1TrackBar.Maximum = 100;
            this.jasnosc1TrackBar.Minimum = -100;
            this.jasnosc1TrackBar.Name = "jasnosc1TrackBar";
            this.jasnosc1TrackBar.Size = new System.Drawing.Size(196, 69);
            this.jasnosc1TrackBar.TabIndex = 18;
            this.jasnosc1TrackBar.Scroll += new System.EventHandler(this.jasnosc1TrackBar_Scroll);
            // 
            // nasycenie1TrackBar
            // 
            this.nasycenie1TrackBar.Location = new System.Drawing.Point(124, 698);
            this.nasycenie1TrackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nasycenie1TrackBar.Maximum = 100;
            this.nasycenie1TrackBar.Minimum = -100;
            this.nasycenie1TrackBar.Name = "nasycenie1TrackBar";
            this.nasycenie1TrackBar.Size = new System.Drawing.Size(196, 69);
            this.nasycenie1TrackBar.TabIndex = 19;
            this.nasycenie1TrackBar.Scroll += new System.EventHandler(this.nasycenie1TrackBar_Scroll);
            // 
            // kontrast1TrackBar
            // 
            this.kontrast1TrackBar.Location = new System.Drawing.Point(124, 777);
            this.kontrast1TrackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kontrast1TrackBar.Maximum = 100;
            this.kontrast1TrackBar.Minimum = -100;
            this.kontrast1TrackBar.Name = "kontrast1TrackBar";
            this.kontrast1TrackBar.Size = new System.Drawing.Size(196, 69);
            this.kontrast1TrackBar.TabIndex = 20;
            this.kontrast1TrackBar.Scroll += new System.EventHandler(this.kontrast1TrackBar_Scroll);
            // 
            // buttonStopRecording
            // 
            this.buttonStopRecording.Enabled = false;
            this.buttonStopRecording.Location = new System.Drawing.Point(426, 551);
            this.buttonStopRecording.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStopRecording.Name = "buttonStopRecording";
            this.buttonStopRecording.Size = new System.Drawing.Size(186, 35);
            this.buttonStopRecording.TabIndex = 21;
            this.buttonStopRecording.Text = "Przestań nagrywać";
            this.buttonStopRecording.UseVisualStyleBackColor = true;
            this.buttonStopRecording.Click += new System.EventHandler(this.buttonStopRecording_Click);
            // 
            // differenceLabel
            // 
            this.differenceLabel.AutoSize = true;
            this.differenceLabel.Location = new System.Drawing.Point(389, 620);
            this.differenceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.differenceLabel.Name = "differenceLabel";
            this.differenceLabel.Size = new System.Drawing.Size(112, 20);
            this.differenceLabel.TabIndex = 22;
            this.differenceLabel.Text = "Procent ruchu:";
            // 
            // zoomLabel
            // 
            this.zoomLabel.AutoSize = true;
            this.zoomLabel.Location = new System.Drawing.Point(36, 875);
            this.zoomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zoomLabel.Name = "zoomLabel";
            this.zoomLabel.Size = new System.Drawing.Size(50, 20);
            this.zoomLabel.TabIndex = 23;
            this.zoomLabel.Text = "Zoom";
            // 
            // zoomTrackBar
            // 
            this.zoomTrackBar.Location = new System.Drawing.Point(124, 855);
            this.zoomTrackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zoomTrackBar.Maximum = 100;
            this.zoomTrackBar.Minimum = -100;
            this.zoomTrackBar.Name = "zoomTrackBar";
            this.zoomTrackBar.Size = new System.Drawing.Size(196, 69);
            this.zoomTrackBar.TabIndex = 24;
            this.zoomTrackBar.Scroll += new System.EventHandler(this.zoomTrackBar_Scroll);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pbCam1);
            this.panel1.Location = new System.Drawing.Point(22, 138);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 403);
            this.panel1.TabIndex = 25;
            // 
            // buttonGenerateHTML
            // 
            this.buttonGenerateHTML.Location = new System.Drawing.Point(364, 855);
            this.buttonGenerateHTML.Name = "buttonGenerateHTML";
            this.buttonGenerateHTML.Size = new System.Drawing.Size(254, 38);
            this.buttonGenerateHTML.TabIndex = 26;
            this.buttonGenerateHTML.Text = "Generuj HTML";
            this.buttonGenerateHTML.UseVisualStyleBackColor = true;
            this.buttonGenerateHTML.Click += new System.EventHandler(this.buttonGenerateHTML_Click);
            // 
            // buttonStopGenerateHTML
            // 
            this.buttonStopGenerateHTML.Enabled = false;
            this.buttonStopGenerateHTML.Location = new System.Drawing.Point(364, 913);
            this.buttonStopGenerateHTML.Name = "buttonStopGenerateHTML";
            this.buttonStopGenerateHTML.Size = new System.Drawing.Size(254, 38);
            this.buttonStopGenerateHTML.TabIndex = 27;
            this.buttonStopGenerateHTML.Text = "Przestan generować HTML";
            this.buttonStopGenerateHTML.UseVisualStyleBackColor = true;
            this.buttonStopGenerateHTML.Click += new System.EventHandler(this.buttonStopGenerateHTML_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 985);
            this.Controls.Add(this.buttonStopGenerateHTML);
            this.Controls.Add(this.buttonGenerateHTML);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.zoomTrackBar);
            this.Controls.Add(this.zoomLabel);
            this.Controls.Add(this.differenceLabel);
            this.Controls.Add(this.buttonStopRecording);
            this.Controls.Add(this.kontrast1TrackBar);
            this.Controls.Add(this.nasycenie1TrackBar);
            this.Controls.Add(this.jasnosc1TrackBar);
            this.Controls.Add(this.contrast1label);
            this.Controls.Add(this.saturation1label);
            this.Controls.Add(this.brightness1label);
            this.Controls.Add(this.buttonRecordingCamOne);
            this.Controls.Add(this.buttonPictureCamOne);
            this.Controls.Add(this.buttonSsCam1);
            this.Controls.Add(this.labelCamera1);
            this.Controls.Add(this.cmbDevList1);
            this.Controls.Add(this.button_searchDev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainWindow";
            this.Text = "USBCam";
            ((System.ComponentModel.ISupportInitialize)(this.pbCam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jasnosc1TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nasycenie1TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kontrast1TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomTrackBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_searchDev;
        private System.Windows.Forms.ComboBox cmbDevList1;
        private System.Windows.Forms.PictureBox pbCam1;
        private System.Windows.Forms.Label labelCamera1;
        private System.Windows.Forms.Button buttonSsCam1;
        private System.Windows.Forms.Button buttonPictureCamOne;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button buttonRecordingCamOne;
        private System.Windows.Forms.Button buttonStopRecordingCamOne;
        private System.Windows.Forms.Label brightness1label;
        private System.Windows.Forms.Label saturation1label;
        private System.Windows.Forms.Label contrast1label;
        private System.Windows.Forms.TrackBar jasnosc1TrackBar;
        private System.Windows.Forms.TrackBar nasycenie1TrackBar;
        private System.Windows.Forms.TrackBar kontrast1TrackBar;
        private System.Windows.Forms.Button buttonStopRecording;
        private System.Windows.Forms.Label differenceLabel;
        private System.Windows.Forms.Label zoomLabel;
        private System.Windows.Forms.TrackBar zoomTrackBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonGenerateHTML;
        private System.Windows.Forms.Button buttonStopGenerateHTML;
    }
}

