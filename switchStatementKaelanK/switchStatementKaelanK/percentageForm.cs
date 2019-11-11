/*
 * Created by: Kaelan K
 * Created on: 11-11-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #32 - Percentage Program
 * This program takes a users level and converts it to a percentage
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

namespace switchStatementKaelanK
{
    public partial class frmPercentage : Form
    {
        public frmPercentage()
        {
            InitializeComponent();
        }

        private int ConvertGrade (String grade)
        {
            // setting func var
            int percentage;

            // check to convert grade to percentage
            switch (grade)
            {
                case "4++":
                    percentage = 98;
                    break;
                case "4+":
                    percentage = 95;
                    break;
                case "4":
                    percentage = 85;
                    break;
                case "4-":
                    percentage = 80;
                    break;
                case "3+":
                    percentage = 78;
                    break;
                case "3":
                    percentage = 75;
                    break;
                case "3-":
                    percentage = 72;
                    break;
                case "2+":
                    percentage = 68;
                    break;
                case "2":
                    percentage = 65;
                    break;
                case "2-":
                    percentage = 62;
                    break;
                case "1+":
                    percentage = 58;
                    break;
                case "1":
                    percentage = 55;
                    break;
                case "1-":
                    percentage = 52;
                    break;
                case "0+":
                    percentage = 45;
                    break;
                case "0":
                    percentage = 40;
                    break;
                case "0-":
                    percentage = 35;
                    break;
                case "0--":
                    percentage = 30;
                    break;
                case "0---":
                    percentage = 20;
                    break;
                case "0----":
                    percentage = 10;
                    break;
                default:
                    percentage = -1;
                    break;

            }

            // return value
            return percentage;

        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            // declaring vars
            string userGrade;
            int userPercentage;

            // set user grade to text value
            userGrade = this.txtInput.Text;

            // call function
            userPercentage = ConvertGrade(userGrade);

            // display message box with returned value
            MessageBox.Show("Your mark as a percentage is a " + userPercentage);
        }
    }
}
