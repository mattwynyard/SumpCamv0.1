using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Drawing.Imaging;
using System.Threading;

namespace SumpCam
{
    public partial class Form1 : Form
    {
        public delegate void UpdateUIDelegate(Image image);
        VideoCapture mCapture;
        Boolean play = false;
        int mHeight;
        int mWidth;

        public Form1()
        {
            InitializeComponent();

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void intialize()
        {
            //mCapture = new VideoCapture("Z:\\Matt\\Buddy Guy, Ronnie Wood & Johnny Lang Miss You Crossroads Guitar Festival 2010.mp4");
            mCapture = new VideoCapture(0);
            if (mCapture.IsOpened)
            {
                const string message = "Video capture has been opened correctly";
                const string caption = "Form";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);

            } else
            {
                const string message = "Video capture is closed";
                const string caption = "Form";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Exclamation);

                // If the no button was pressed ...
                if (result == DialogResult.OK)
                {
                    // cancel the closure of the form.
                    //Close();
                }
            }
            mHeight = mCapture.Height;
            mWidth = mCapture.Width;
            double fps = mCapture.GetCaptureProperty(CapProp.Fps);
            double exposure = mCapture.GetCaptureProperty(CapProp.Exposure);
            double frameCount = mCapture.GetCaptureProperty(CapProp.FrameCount);
            double contrast = mCapture.GetCaptureProperty(CapProp.Contrast);
            double brightness = mCapture.GetCaptureProperty(CapProp.Brightness);

            getFrame();

        }

        public void getFrame()
        {
            Task.Factory.StartNew(() =>
            {

                while (mCapture != null)
                {
                    Mat frame = new Mat(mHeight, mWidth, DepthType.Cv8U, 3);
                    mCapture.Read(frame);
                                   
                    Image<Bgr, Byte> image = frame.ToImage<Bgr, Byte>();
                    Image img = ImageFromEMGUImage(image);
                    SetPicture(img);
                    Thread.Sleep(100);
                }
            });
            
        }



        private void SetPicture(Image img)
        {
            if (boxPicture.InvokeRequired)
            {
                boxPicture.Invoke(new MethodInvoker(
                delegate ()
                {
                    boxPicture.Image = img;
                }));
            }
            else
            {
                boxPicture.Image = img;
            }
        }

        public static Image ImageFromEMGUImage(Image<Bgr, Byte> image)
        {
            MemoryStream ms = new MemoryStream();
            Image bitmap = image.ToBitmap();
            image.Dispose();
            bitmap.Save(ms, ImageFormat.Jpeg);
            bitmap.Dispose();
            ms.Seek(0, SeekOrigin.Begin);
            return Image.FromStream(ms);
        }

        

        private void btnIntialise_Click(object sender, EventArgs e)
        {
            intialize();
        }

        private void BtnClick_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                Mat frame = new Mat(mHeight, mWidth, DepthType.Cv8U, 3);
                mCapture.Read(frame);
                Mat dst = new Mat(mHeight, mWidth, DepthType.Cv8U, 3);
                CvInvoke.FastNlMeansDenoisingColored(frame, dst, 1, 5);
                Image<Bgr, Byte> image = dst.ToImage<Bgr, Byte>();
                Image img = ImageFromEMGUImage(image);
                img.Save("C:\\Onsite\\SumpCam\\temp\\test.jpg", ImageFormat.Jpeg);
            });
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
