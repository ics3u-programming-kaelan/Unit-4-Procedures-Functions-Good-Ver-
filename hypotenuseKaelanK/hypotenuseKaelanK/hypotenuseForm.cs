/*
 * Created by: Kaelan K
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #31 - Hypotenuse
 * This program takes the two sides of the triangle and calculates the hypotenuse
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

namespace hypotenuseKaelanK
{
    public partial class hypotenuseForm : Form
    {
        public hypotenuseForm()
        {
            InitializeComponent();
        }

        public double CalculateHypotenuse (double sideA, double sideB)
        {
            // declaring var
            double sideC;

            // calculating hypotenuse
            sideC = Math.Sqrt((sideA * sideA) + (sideB * sideB));

            return sideC;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declaring variables
            double sideA;
            double sideB;
            double sideC;

            // setting variables
            sideA = Double.Parse(txtSideA.Text);
            sideB = Double.Parse(txtSideB.Text);

            // calling function
            sideC = CalculateHypotenuse(sideA, sideB);

            // displaying called value
            this.lblOutput.Text = Convert.ToString(sideC);
        }
    }
}
