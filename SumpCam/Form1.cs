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

namespace SumpCam
{
    public partial class Form1 : Form
    {

        VideoCapture mCapture;
        Boolean play = false;

        public Form1()
        {
            InitializeComponent();
            intialize();

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

                // If the no button was pressed ...
                if (result == DialogResult.OK)
                {
                    openStream(mCapture);
                    //Close();

                }
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

        }

        public void openStream(VideoCapture capture)
        {
            //Boolean grab = mCapture.Grab();
            int height = mCapture.Height;
            int width = mCapture.Width;
            Boolean grab = mCapture.Grab();
            Mat frame = new Mat(height, width, DepthType.Cv8U, 3);
            mCapture.Read(frame);
            Image<Bgr, Byte> image = frame.ToImage<Bgr, Byte>();
            boxPicture.Image = ImageFromEMGUImage(image);
            

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

        private void btnPicture_Click(object sender, EventArgs e)
        {
            if (play)
            {
                play = false;
                return;
            } else
            {
                play = true;
            }
            

        }

        private void btnIntialise_Click(object sender, EventArgs e)
        {
            
            openStream(mCapture);
        }
    }
}
