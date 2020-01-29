/*
 * Created by: Kaelan Khan
 * Created on: 30-10-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #30 - Area Procedure
 * This program takes the users celsius and converts it to fahrenheit
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

namespace tempConverterKaelanK
{
    public partial class frmTempConverter : Form
    {
        public frmTempConverter()
        {
            InitializeComponent();
        }

        public void CalculateF(double celsius)
        {
            // declare local var
            double convertedTemp;

            // calculate the converted temp
            convertedTemp = celsius * 1.8 + 32;

            // display a message box
            MessageBox.Show(celsius + " Celsius" + " = " + convertedTemp + " Fahrenheit");
        }
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare variable
            double celsius;

            // convert user input to number
            celsius = Double.Parse(this.textBox1.Text);

            // call on calculateF
            this.CalculateF(celsius);

        }

        private void FrmTempConverter_Load(object sender, EventArgs e)
        {

        }
    }
}
