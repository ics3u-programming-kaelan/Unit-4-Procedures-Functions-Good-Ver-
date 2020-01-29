using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dynamicPicBox
{
    public partial class frmDynamicPic : Form
    {
        public frmDynamicPic()
        {
            InitializeComponent();
            this.lblInstructions.Hide();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox tmpPicMan = (PictureBox)sender;

            // declare local vars and consts
            const byte MAX_FRAMES = 10;
            int pictureFrameCounter = 1;

            // continue this loop while the frame counter has not reached 01
            while (pictureFrameCounter < MAX_FRAMES + 1)
            {
                if (pictureFrameCounter == 1)
                {
                    tmpPicMan.Image = Properties.Resources.walk1;
                }
                else if (pictureFrameCounter == 2)
                {
                    tmpPicMan.Image = Properties.Resources.walk2;
                }
                else if (pictureFrameCounter == 3)
                {
                    tmpPicMan.Image = Properties.Resources.walk3;
                }
                else if (pictureFrameCounter == 4)
                {
                    tmpPicMan.Image = Properties.Resources.walk4;
                }
                else if (pictureFrameCounter == 5)
                {
                    tmpPicMan.Image = Properties.Resources.walk5;
                }
                else if (pictureFrameCounter == 6)
                {
                    tmpPicMan.Image = Properties.Resources.walk6;
                }
                else if (pictureFrameCounter == 7)
                {
                    tmpPicMan.Image = Properties.Resources.walk7;
                }
                else if (pictureFrameCounter == 8)
                {
                    tmpPicMan.Image = Properties.Resources.walk8;
                }
                else if (pictureFrameCounter == 9)
                {
                    tmpPicMan.Image = Properties.Resources.walk9;
                }
                else if (pictureFrameCounter == 10)
                {
                    tmpPicMan.Image = Properties.Resources.walk10;
                }

                pictureFrameCounter++;

                //refresh the form
                this.Refresh();

                // pause the loop for 100 ms
                
            }

        private void GeneratePictureBox(int x, int y)
        {
            // dynamicly create a pic and move it to designated space
            PictureBox tmpPicMan = new PictureBox();
            Point pntPic = new System.Drawing.Point(x, y);

            // set location of image
            tmpPicMan.Location = pntPic;

            // assign the image to pic
            tmpPicMan.Image = Properties.Resources.walk1;

            // stretch image to fit the pic
            tmpPicMan.SizeMode = PictureBoxSizeMode.StretchImage;

            // make the pic the same size as image
            tmpPicMan.ClientSize = new Size(Properties.Resources.walk1.Width, Properties.Resources.walk1.Height);

            // add the event listener
            tmpPicMan.Click += new System.EventHandler(PictureBox_Click);

            // add the pic to the form
            this.Controls.Add(tmpPicMan);
        }

        private void GeneratePictureBoxes()
        {
            GeneratePictureBox(61, 78);
            
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // display instructions
            this.lblInstructions.Show();

            // generate the pic
            GeneratePictureBoxes();
        }
    }
}
