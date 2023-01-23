using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;

using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Superres;
using Emgu.CV.Util;
using System.Text.RegularExpressions;
using System.Runtime.Remoting.Messaging;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;
using Emgu.CV.Cuda;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Drawing.Imaging;

namespace openCV_secondApp
{
    public partial class Form2 : Form
    {
        Mat prevImage;
        Mat currentImage;
        int count = 0;
        VideoCapture capture;
        double motionThreshold = 35;
        bool saveImage;
        int camNum;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            trackBar1.Value = (int)motionThreshold;
            saveImage = Convert.ToBoolean(chkBxSaveImage.CheckState);
            txtBxSavePath.Text = Properties.Settings.Default.savePath;
            cmbBxCamNum.SelectedIndex = 0;
            
            
        }

       
        public void runCam()
        {
            capture = new VideoCapture(camNum);
            prevImage = new Mat();
            capture.ImageGrabbed += imageGrabbed;
            capture.Start();
            // to pass the parameter to the event handler
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtBxSavePath.Enabled = false;
            runCam();
        }
        private void imageGrabbed(object sender, EventArgs e)
        {
            // Set Status to Idle
            //lblStatus.Text = "Idle"; lblStatus.ForeColor= System.Drawing.Color.Black;
            

            currentImage = capture.QueryFrame();
            Mat showImage = (Mat)currentImage.Clone();

            Mat Frame = prevImage;
            Mat Frame2= (Mat)currentImage.Clone();

            Mat FrameDummy = Frame;
            Mat Frame2Dummy = Frame2;
            try
            {
                CvInvoke.CvtColor(Frame, FrameDummy, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
            }
            catch (CvException ex) {
                prevImage = currentImage;
                return ;
            }
            CvInvoke.GaussianBlur(FrameDummy, FrameDummy, new Size(21, 21), 0);

            try
            {
                CvInvoke.CvtColor(Frame2Dummy, Frame2, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
            }
            catch { }
            CvInvoke.GaussianBlur(Frame2Dummy, Frame2Dummy, new Size(21, 21), 0);

            Mat Difference1 = new Mat();
            CvInvoke.AbsDiff(FrameDummy, Frame2Dummy, Difference1);
            //Previous_Frame = Frame;

            Mat Thr = new Mat();
            
            CvInvoke.Threshold(Difference1, Thr, motionThreshold, 255, Emgu.CV.CvEnum.ThresholdType.Binary);
            //CvInvoke.Dilate(Thr, Thr, 0);
            Emgu.CV.Util.VectorOfVectorOfPoint contours = new Emgu.CV.Util.VectorOfVectorOfPoint();
            Mat hierarchy = new Mat();
            Mat ThrDup = Thr;
            CvInvoke.FindContours(ThrDup, contours, hierarchy, Emgu.CV.CvEnum.RetrType.Tree, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
            
            if (contours.Length > 0)
            {
                
                onDetection();
            }
            else
            {
                ThreadHelperClass.SetText(this, lblStatus, "No Motion!");
            }
            CvInvoke.DrawContours(showImage, contours, -1, new MCvScalar(100, 100, 0));


            // Save the Image

            //ThreadHelperClass.SetText(this, lblStatus, contours.Length.ToString());
            //lblStatus.Text = contours.Length.ToString();

            prevImage = currentImage;
            
            pictureBox1.Image = showImage.ToBitmap();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;



        }

        public void onDetection()
        {
            ThreadHelperClass.SetText(this, lblStatus, "Motion Detected!");
            if (saveImage && txtBxSavePath.Text!="")
            {
                saveImageFun(currentImage.ToBitmap(), txtBxSavePath.Text);
            }
        }

        public void saveImageFun(Bitmap img, string BasePath)
        {
            string savePath = BasePath + "/";
            savePath = savePath + DateTime.Now.ToString("yyyy/MM/dd") + "/";
            if (!Directory.Exists(savePath))
            {
                Directory.CreateDirectory(savePath);
            }
            string saveName = savePath + DateTime.Now.ToString("hh-mm-ss")+".jpg";
            img.Save(saveName, ImageFormat.Jpeg);
        }

        private void stop_Click(object sender, EventArgs e)
        {
            stopCapture();
        }
        public void stopCapture()
        {
            if (capture is  null)
            {
                
            }
            else
            {
                if (capture.IsOpened)
                {
                    capture.Stop();
                    txtBxSavePath.Enabled = true;
                    pictureBox1.Image = new Mat().ToBitmap();
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
        }

        private void txtBxTracBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            txtBxTracBar.Text = trackBar1.Value.ToString();
            motionThreshold = trackBar1.Value;
        }

        private void txtBxTracBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                try
                {
                    trackBar1.Value = int.Parse(txtBxTracBar.Text);
                }
                catch { }
            }
        }

        private void chkBxSaveImage_CheckedChanged(object sender, EventArgs e)
        {
            saveImage=Convert.ToBoolean(chkBxSaveImage.CheckState);
            
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog1 = new FolderBrowserDialog();
            //MessageBox.Show(DateTime.Now.ToString("hh-mm-ss") + " : " + DateTime.Now.ToString("yyyy/MM/dd"));
            // Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folderName = folderBrowserDialog1.SelectedPath;
                //Do your work here!
                txtBxSavePath.Text = folderName;
            }
        }

        private void txtBxSavePath_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.savePath = txtBxSavePath.Text;
            Properties.Settings.Default.Save();
        }

        private void cmbBxCamNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            stopCapture();
            camNum = cmbBxCamNum.SelectedIndex;
        }
    }
}
