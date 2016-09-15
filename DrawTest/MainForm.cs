using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawTest
{
    public partial class MainForm : Form
    {
        private bool _drawLineMode { get; set; } = false;
        private Bitmap pageImage { get; set; }
        private Point _startPoint { get; set; }
        private int ZoomLevel { get; set; } = 100;
        private bool ZoomToFit { get; set; } = true;



        public MainForm()
        {
            InitializeComponent();

            picturePanel.AutoScroll = false;
            resizeImage();
        }

        private void DisplayPage()
        {
            pbPageImage.Image = pageImage;
        }

        private void drawLine_Click(object sender, EventArgs e)
        {
            _drawLineMode = true;
            statusMessage.Text = "Draw line mode: hold the mouse button down to draw the line";
        }

        private void drawOthers_Click(object sender, EventArgs e)
        {

        }

        private void resizeImage()
        {
            if(ZoomToFit)
            {
                picturePanel.AutoScroll = false;
                Size panelSize = picturePanel.Size;
                pbPageImage.Size = panelSize;
            }
            else
            {
                picturePanel.AutoScroll = true;
                pbPageImage.Width = ZoomLevel * picturePanel.Width / 100;
                pbPageImage.Height = ZoomLevel * picturePanel.Height / 100;
            }

            DisplayPage();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            resizeImage();
        }

        private void pbPageImage_MouseDown(object sender, MouseEventArgs e)
        {
            if(_drawLineMode)
            {
                _startPoint = e.Location;
                statusMessage.Text = "Draw line mode: release the mouse button to finish drawing the line";
                fromLocation.Text = "From: " + e.Location.ToString();
                fromLocation.Visible = true;
                toLocation.Visible = true;
            }
        }

        private void pbPageImage_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pbPageImage_MouseHover(object sender, EventArgs e)
        {

        }

        private void pbPageImage_MouseLeave(object sender, EventArgs e)
        {
            if(_drawLineMode)
            {
                statusMessage.Text = "Draw line mode cancelled: mouse moved outside the image area";
                _drawLineMode = false;
            }
        }

        private void pbPageImage_MouseMove(object sender, MouseEventArgs e)
        {
            if( _drawLineMode)
            {
                toLocation.Text = "to: " + e.Location.ToString();
            }

            if(insideImage(e.Location))
            {
                hitCheck.Text = "Inside";
            }
            else
            {
                hitCheck.Text = "Outside";
            }
        }

        private void pbPageImage_MouseUp(object sender, MouseEventArgs e)
        {
            if(_drawLineMode)
            {
                Point endPoint = e.Location;
                endPoint.Y = _startPoint.Y;
                _drawLineMode = false;
                toLocation.Text = "to: " + endPoint.ToString();
                statusMessage.Text = "Draw line mode ended: mouse button released";

                Pen blackPen = new Pen(Color.Black, 3);
                
                using (var graphics = pbPageImage.CreateGraphics())
                {
                    graphics.DrawLine(blackPen, _startPoint, endPoint);
                }
            }
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Flasks_Click(object sender, EventArgs e)
        {
            pageImage = Resource1.chemical_flasks_2_1417112;
            DisplayPage();
        }
        
        private void FrontPage_Click(object sender, EventArgs e)
        {
            pageImage = Resource1.FrontPage;
            DisplayPage();
        }

        /// <summary>
        /// Check to see if a point is inside the actual image
        /// </summary>
        /// 
        /// <param name="point">The point to check</param>
        /// <returns>True if the point is inside the image, false otherwise</returns>
        /// 
        private bool insideImage(Point point)
        {

            return false;
        }
    }
}
