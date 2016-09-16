using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DrawTest
{
    /// <summary>
    /// Test code for drawing lines and other objects on a page.
    /// </summary>
    public partial class MainForm : Form
    {
        private bool _drawLineMode { get; set; } = false;
        private Image pageImage { get; set; }
        private Point _startPoint { get; set; }
        private int ZoomLevel { get; set; } = 100;
        private bool ZoomToFit { get; set; } = true;



        public MainForm()
        {
            InitializeComponent();
            //pageImage = Resource1.FrontPage;
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
                if(pageImage==null)
                {
                    //pbPageImage.Size = picturePanel.Size;
                }
                else
                {
                    // See the ImageSizing spreadsheet for a decision tree
                    pbPageImage.Size = picturePanel.Size;

                    // Find out the two aspect rations
                    double imageAspectRatio = aspectRatio(pageImage.Size);
                    double panelAspectRation = aspectRatio(picturePanel.Size);

                    if(imageAspectRatio==1 && panelAspectRation==1)
                    {
                        // This should be a rare case, the books are expected to be portrait
                        // The size of the picturebox is left the same as the picturepanel size 
                        // (because a square will neatly scale to fit into a square).
                    } else if (imageAspectRatio<1)
                    {
                        // The image is taller than wide, so the width needs adjusting to fit.
                        pbPageImage.Width = (int)((double)pbPageImage.Width * imageAspectRatio);
                    } else
                    {
                        // In all other cases, the height needs adjusting to fit.
                        pbPageImage.Height = (int)((double)pbPageImage.Height * imageAspectRatio);
                    }
                }

            }
            else
            {
                picturePanel.AutoScroll = true;
                pbPageImage.Width = ZoomLevel * picturePanel.Width / 100;
                pbPageImage.Height = ZoomLevel * picturePanel.Height / 100;
            }

            DisplayPage();
        }

        private double aspectRatio(Size item)
        {
            return (double)item.Width / item.Height;
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
            ImageChanged();
            DisplayPage();
        }
        
        private void FrontPage_Click(object sender, EventArgs e)
        {
            pageImage = Resource1.FrontPage;
            ImageChanged();
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
            
            bool rv = false;
            try
            {
                // Do the clever stuff here
                Point pointPageImage = PointToScreen(new Point(pbPageImage.Bounds.Left, pbPageImage.Bounds.Top));
                Point pointCursor = Cursor.Position;

                pointPageImage.X = pointCursor.X - pointPageImage.X;
                pointPageImage.Y = pointCursor.Y - pointPageImage.Y;
                
                int _absoluteImagePositionX = pbPageImage.Width / 2 - pageImage.Width / 2;
                int _absoluteImagePositionY = pbPageImage.Height / 2 - pageImage.Height / 2;

                rv = pbPageImage.ClientRectangle.Contains(PointToClient(Control.MousePosition));
                
            }
            catch (Exception)
            {
                // I don't care
            }
            return rv;
        }

        private void FrameChanged()
        {
            foreach(Object item in groupBox2.Controls)
            {
                if(item is RadioButton)
                {
                    RadioButton rb = (RadioButton)item;
                    if (rb.Checked)
                    {
                        FrameChanged(rb);
                        break;
                    }
                }
            }
        }
        private void FrameChanged(object sender, EventArgs e)
        {
            FrameChanged((RadioButton)sender);
        }

        private void FrameChanged(RadioButton rb)
        {
            TableLayoutPanelCellPosition pos = tableLayoutPanel1.GetCellPosition(picturePanel);
            int width = tableLayoutPanel1.GetColumnWidths()[pos.Column];
            int height = tableLayoutPanel1.GetRowHeights()[pos.Row];
            Size cell = new Size(width, height);

            if (rb.Text == "Tall")
            {
                picturePanel.Height = height;
                picturePanel.Width = (int)(height / aspectRatio(cell));
                picturePanel.Top = 0;
                picturePanel.Left = (width - picturePanel.Width) / 2;
            }
            else if (rb.Text == "Square")
            {
                int size = 3 * Math.Min(width, height) / 4;
                picturePanel.Height = size;
                picturePanel.Width = size;
                picturePanel.Top = (height - picturePanel.Height) / 2;
                picturePanel.Left = (width - picturePanel.Width) / 2;
            }
            else if (rb.Text == "Wide")
            {
                picturePanel.Height = (int)(height * aspectRatio(cell));
                picturePanel.Width = width;
                picturePanel.Top = (height - picturePanel.Height) / 2;
                picturePanel.Left = 0;
            }
            else
            {
                Debug.Assert(false, "Wasn't expecting this!");
            }
            ImageChanged();
        }

        private void ImageChanged()
        {
            foreach (Object item in groupBox1.Controls)
            {
                if (item is RadioButton)
                {
                    RadioButton rb = (RadioButton)item;
                    if (rb.Checked)
                    {
                        ImageChanged(rb);
                        break;
                    }
                }
            }
        }

        private void ImageChanged(object sender, EventArgs e)
        {
            ImageChanged((RadioButton)sender);
        }
        
        private void ImageChanged(RadioButton rb)
        {
            Size cell = picturePanel.Size;

            if (rb.Text == "Tall")
            {
                pbPageImage.Height = cell.Height;
                pbPageImage.Width = (int)((double)Size.Width / aspectRatio(cell));
                pbPageImage.Top = 0;
                pbPageImage.Left = (cell.Width - pbPageImage.Width) / 2;
            }
            else if (rb.Text == "Square")
            {
                pbPageImage.Size = cell;
                pbPageImage.Top = 0;
                pbPageImage.Left = 0;
            }
            else if (rb.Text == "Wide")
            {
                pbPageImage.Height = (int)((double)Size.Height * aspectRatio(cell));
                pbPageImage.Width = cell.Width;
                pbPageImage.Top = (cell.Height - pbPageImage.Height) / 2;
                pbPageImage.Left = 0;
            }
            else
            {
                Debug.Assert(false, "Wasn't expecting this!");
            }


            Image img = new Bitmap(pbPageImage.Width, pbPageImage.Height);
            Rectangle rect = new Rectangle(pbPageImage.Left + 2, pbPageImage.Top + 2, pbPageImage.Width - 4, pbPageImage.Height - 4);
            using (var graphics = Graphics.FromImage(img))
            {
                Pen blackPen = new Pen(Color.Black, 3);
                Pen redPen = new Pen(Color.Red, 5);
                graphics.DrawRectangle(blackPen, rect);
                graphics.DrawEllipse(redPen, rect);
            }

            pageImage = img;
            DisplayPage();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            FrameChanged();
            ImageChanged();
        }
    }
}
