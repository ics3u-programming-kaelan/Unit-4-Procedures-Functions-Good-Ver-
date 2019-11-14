/*
 * Created by: Kaelan K
 * Created on: 13-11-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - passByRef
 * This program ranomdly changes the picture when the picture button is clicked
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passByRefKaelanK
{
    public partial class passByRefForm : Form
    {
        Random randNumberGenerator = new Random();

        public passByRefForm()
        {
            InitializeComponent();
        }

        private void ChangeCard (ref PictureBox aPictureBox, int cardNumber)
        {
            if (cardNumber == 1)
            {
                aPictureBox.Image = Properties.Resources.Front;
            }
            else if (cardNumber == 2)
            {
                aPictureBox.Image = Properties.Resources.JC;
            }
            else if (cardNumber == 3)
            {
                aPictureBox.Image = Properties.Resources.JD;
            }
            else if (cardNumber == 4)
            {
                aPictureBox.Image = Properties.Resources.JH;
            }
            else if (cardNumber == 5)
            {
                aPictureBox.Image = Properties.Resources.JS;
            }
            else if (cardNumber == 6)
            {
                aPictureBox.Image = Properties.Resources.KC;
            }
            else if (cardNumber == 7)
            {
                aPictureBox.Image = Properties.Resources.KD;
            }
            else if (cardNumber == 8)
            {
                aPictureBox.Image = Properties.Resources.KH;
            }
            else if (cardNumber == 9)
            {
                aPictureBox.Image = Properties.Resources.KS;
            }
            else if (cardNumber == 10)
            {
                aPictureBox.Image = Properties.Resources.QC;
            }
            else if (cardNumber == 11)
            {
                aPictureBox.Image = Properties.Resources.QD;
            }
            else if (cardNumber == 12)
            {
                aPictureBox.Image = Properties.Resources.QH;
            }
            else if (cardNumber == 13)
            {
                aPictureBox.Image = Properties.Resources.QS;
            }
        }

        private void picCard_Clicked(object sender, EventArgs e)
        {
            // declaring local constant
            const int MAX_NUM = 13;

            // declaring local var
            int aRandomNumber;

            // get random number between 1 and 13
            aRandomNumber = randNumberGenerator.Next(1, MAX_NUM + 1);

            // call function
            ChangeCard(ref this.picCard, aRandomNumber);
        }
    }
}
