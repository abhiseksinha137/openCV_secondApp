namespace openCV_secondApp
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnStart = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.txtBxTracBar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkBxSaveImage = new System.Windows.Forms.CheckBox();
            this.txtBxSavePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.cmbBxCamNum = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(0, 0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Cam";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(81, 0);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 1;
            this.stop.Text = "Stop Cam";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sensitivity";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(896, 496);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(743, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(789, 6);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(24, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Idle";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(223, 4);
            this.trackBar1.Maximum = 150;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // txtBxTracBar
            // 
            this.txtBxTracBar.Location = new System.Drawing.Point(333, 3);
            this.txtBxTracBar.Name = "txtBxTracBar";
            this.txtBxTracBar.Size = new System.Drawing.Size(42, 20);
            this.txtBxTracBar.TabIndex = 7;
            this.txtBxTracBar.TextChanged += new System.EventHandler(this.txtBxTracBar_TextChanged);
            this.txtBxTracBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBxTracBar_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "SaveImage";
            // 
            // chkBxSaveImage
            // 
            this.chkBxSaveImage.AutoSize = true;
            this.chkBxSaveImage.Checked = true;
            this.chkBxSaveImage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBxSaveImage.Location = new System.Drawing.Point(451, 6);
            this.chkBxSaveImage.Name = "chkBxSaveImage";
            this.chkBxSaveImage.Size = new System.Drawing.Size(15, 14);
            this.chkBxSaveImage.TabIndex = 9;
            this.chkBxSaveImage.UseVisualStyleBackColor = true;
            this.chkBxSaveImage.CheckedChanged += new System.EventHandler(this.chkBxSaveImage_CheckedChanged);
            // 
            // txtBxSavePath
            // 
            this.txtBxSavePath.Location = new System.Drawing.Point(473, 2);
            this.txtBxSavePath.Name = "txtBxSavePath";
            this.txtBxSavePath.Size = new System.Drawing.Size(198, 20);
            this.txtBxSavePath.TabIndex = 10;
            this.txtBxSavePath.TextChanged += new System.EventHandler(this.txtBxSavePath_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(678, 1);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(59, 23);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // cmbBxCamNum
            // 
            this.cmbBxCamNum.FormattingEnabled = true;
            this.cmbBxCamNum.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbBxCamNum.Location = new System.Drawing.Point(81, 24);
            this.cmbBxCamNum.Name = "cmbBxCamNum";
            this.cmbBxCamNum.Size = new System.Drawing.Size(75, 21);
            this.cmbBxCamNum.TabIndex = 12;
            this.cmbBxCamNum.SelectedIndexChanged += new System.EventHandler(this.cmbBxCamNum_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cam Num";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 547);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBxCamNum);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtBxSavePath);
            this.Controls.Add(this.chkBxSaveImage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBxTracBar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.trackBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "MotionDetection";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox txtBxTracBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkBxSaveImage;
        private System.Windows.Forms.TextBox txtBxSavePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ComboBox cmbBxCamNum;
        private System.Windows.Forms.Label label4;
    }
}