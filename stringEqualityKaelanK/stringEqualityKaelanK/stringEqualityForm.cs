using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stringEqualityKaelanK
{
    public partial class stringEqualityForm : Form
    {
        public stringEqualityForm()
        {
            InitializeComponent();
        }

        private bool StringsAreEqual(string string1, string string2)
        {
            bool isEqual = false;

            int length1;
            int length2;

            length1 = string1.Length;
            length2 = string2.Length;

            if (length1 == length2)
            {
                string1.ToLower();
                string2.ToLower();

                if (string1 == string2)
                {
                    isEqual = true;
                }
                else
                {

                }
            }
            else 
            {

            }

            return isEqual;

        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            // initialize vars
            string string1;
            string string2;

            // set vars
            string1 = this.txtString1.Text;
            string2 = this.txtString2.Text;

            StringsAreEqual(string1, string2);

            if (StringsAreEqual = true)
            {

            }

        }
    }
}
