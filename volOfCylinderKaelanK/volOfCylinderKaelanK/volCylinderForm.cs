/*
 * Created by: Kaelan K
 * Created on: 5-11-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #30 - Volume of a Cylinder
 * This program calculates the volume of a cylinder
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

namespace volOfCylinderKaelanK
{
    public partial class frmVolCylinder : Form
    {
        public frmVolCylinder()
        {
            InitializeComponent();
        }

        private double CalculateVolCylinder(double radius, double height)
        {
            // declaring func var
            double cylinderVol;

            // calculate volume
            cylinderVol = 3.14 * Math.Pow(2, radius) * height;

            // return value
            return cylinderVol;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declaring vars
            double userVolume;
            double userRad;
            double userHeight;

            // setting vars to inputs
            userRad = Double.Parse(txtRadius.Text);
            userHeight = Double.Parse(txtHeight.Text);

            // call the function
            userVolume = CalculateVolCylinder(userRad, userHeight);

            // display returned value
            this.lblOutput.Text = "The volume is: " + userVolume;
        }
    }
}
