using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace roundDecimalKaelanK
{
    public partial class frmRoundDecimal : Form
    {
        public frmRoundDecimal()
        {
            InitializeComponent();
        }

        private void RoundDecimal(ref TextBox dec, ref NumericUpDown places)
        {
            double roundedNum;
            double decNum;
            double decplaces;

            decNum = Double.Parse(this.txtDecimal.Text);
            decplaces = Double.Parse(this.nudPlaces.Text);

            decNum = decNum * Math.Pow(10, decplaces);

            decNum = Math.Truncate(decNum);

            decNum = decNum / Math.Pow(10, decplaces);

            MessageBox.Show ( Convert.ToString(decNum));

             
        }

        private void BtnRound_Click(object sender, EventArgs e)
        {

            // calling procedure when clicked
            RoundDecimal(ref this.txtDecimal, ref this.nudPlaces);
        }
    }
}
