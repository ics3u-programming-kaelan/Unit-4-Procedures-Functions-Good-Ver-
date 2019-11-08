/*
 * Created by: Kaelan K
 * Created on: 08-11-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #29 - Address Program
 * This program takes in the inputs and then displays a users addresss
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

namespace optionalParametersKaelanK
{
    public partial class frmOptionalParameters : Form
    {
        public frmOptionalParameters()
        {
            InitializeComponent();
        }

        public void AddressApt(String apt, String street, String city, String postalCode, String province)
        {
            MessageBox.Show("Your Address is: " + apt + ", " + street + ", " + city + ", " + postalCode + ", " + province);
        }

        public void AddressApt(String street, String city, String postalCode, String province)
        {
            MessageBox.Show("Your Address is: " + street + ", " + city + ", " + postalCode + ", " + province);
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            // declaring variables
            String apt, street, city, postalCode, province;

            // setting variables
            apt = this.textBox1.Text;
            street = this.textBox2.Text;
            city = this.textBox3.Text;
            postalCode = this.textBox4.Text;
            province = this.textBox5.Text;

            // make user enter street
            if (street == "")
            {
                MessageBox.Show("Please enter your street");
            }
            // make user enter city
            else if (city == "")
            {
                MessageBox.Show("Please enter your city");
            }
            // make user entere postal code
            else if (postalCode == "")
            {
                MessageBox.Show("Please enter your postal code");
            }
            //make user enter province
            else if (province == "")
            {
                MessageBox.Show("Please enter you province");
            }
            // call address function without apt
            else if (apt == "")
            {
                AddressApt(street, city, postalCode, province);
            }
            else
            {
                AddressApt(apt, street, city, postalCode, province);
            }

        }
    }
}
