/*
 * Created by: First Last
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Volume of a Cylinder
 * This program...
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
            sideC = Math.Sqrt(Math.Pow(2, sideA), Math.Pow(2, sideB));

            return sideC;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declaring variables
            double sideA;
            double sideB;

            // setting variables
            sideA = Double.Parse(txtSideA.Text);
            sideB = Double.Parse(txtSideB.Text);

            // calling function
            CalculateHypotenuse(sideA, sideB);

        }
    }
}
