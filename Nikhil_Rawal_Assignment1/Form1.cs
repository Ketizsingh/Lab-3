using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Nikhil_Rawal_Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void title_Enter(object sender, EventArgs e)
        {
            if (title.Text == "Title")
            {
                title.Text = "";
                title.ForeColor = Color.Black;
            }
        }

        private void title_Leave(object sender, EventArgs e)
        {
            if (title.Text == "")
            {
                title.Text = "Title";
                title.ForeColor = Color.Silver;
            }

        }

        private void submit_Click(object sender, EventArgs e)
        {

            string titlestring = title.Text;
                if (titlestring == "Title" || titlestring == " ")
                {
                    MessageBox.Show("Please add Title and in Correct Format");
                }

                 string fnamestring = fname.Text;
                if (fnamestring == "First Name" || fnamestring == " ")
                {
                    MessageBox.Show("Please add First Name and in Correct Format");
                }

                 string lnamestring = lname.Text;
                if (lnamestring == "Last Name" || lnamestring == " ")
                {
                    MessageBox.Show("Please add Last Name and in Correct Format");
                }

                 string citystring = city.Text;
                if (citystring == "City" || citystring == " ")
                {
                    MessageBox.Show("Please add City Name and in Correct Format");
                }

                  string provincestring = province.Text;
                if (provincestring == "City" || provincestring == " ")
                {
                    MessageBox.Show("Please add Province Name and in Correct Format");
                }

                  string countrystring = country.Text;
                if (countrystring == "Country" || countrystring == " ")
                {
                    MessageBox.Show("Please add Country Name and in Correct Format");
                }

                  string emailstring = email.Text;
                if (emailstring == "Email ID" || emailstring == " ")
                {
                    MessageBox.Show("Please add Email ID and in Correct Format");
                }

                  string phonestring = phone.Text;
                if (phonestring == "Email ID" || phonestring == " ")
                {
                    MessageBox.Show("Please add Phone number and in Correct Format");
                }

            
        }

        private void fname_Enter(object sender, EventArgs e)
        {
            if (fname.Text == "First Name")
            {
                fname.Text = "";
                fname.ForeColor = Color.Black;
            }

        }

        private void fname_Leave(object sender, EventArgs e)
        {
            if (fname.Text == "")
            {
                fname.Text = "First Name";
                fname.ForeColor = Color.Silver;
            }
        }

        private void lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lname_Enter(object sender, EventArgs e)
        {
            if (lname.Text == "Last Name")
            {
                lname.Text = "";
                lname.ForeColor = Color.Black;
            }
        }

        private void lname_Leave(object sender, EventArgs e)
        {
            if(lname.Text == "")
            {
                lname.Text = "Last Name";
                lname.ForeColor = Color.Silver;
            }
        }

        private void address_Enter(object sender, EventArgs e)
        {
            if (address.Text == "Street Address")
            {
                address.Text = "";
                address.ForeColor = Color.Black;
            }
        }

        private void address_Leave(object sender, EventArgs e)
        {
            if (address.Text == "" )
            {
                address.Text = "Street Address";
                address.ForeColor = Color.Silver;
            }
        }

        private void postalcode_Enter(object sender, EventArgs e)
        {
            if (postalcode.Text == "Postal Code")
            {
                postalcode.Text = "";
                postalcode.ForeColor = Color.Black;
            }
        }

        private void postalcode_Leave(object sender, EventArgs e)
        {
            if (postalcode.Text == "")
            {
                postalcode.Text = "Postal Code";
                postalcode.ForeColor = Color.Silver;
            }
        }

        private void city_Enter(object sender, EventArgs e)
        {
            if (city.Text == "City")
            {
                city.Text = "";
                city.ForeColor = Color.Black;
            }
        }

        private void city_Leave(object sender, EventArgs e)
        {
            if (city.Text == "")
            {
                city.Text = "City";
                city.ForeColor = Color.Silver;
            }
        }

        private void province_Enter(object sender, EventArgs e)
        {
            if (province.Text == "Province")
            {
                province.Text = "";
                province.ForeColor = Color.Black;
            }
        }

        private void province_Leave(object sender, EventArgs e)
        {
            if (province.Text == "")
            {
                province.Text = "Province";
                province.ForeColor = Color.Silver;
            }
        }

        private void country_Enter(object sender, EventArgs e)
        {
            if (country.Text == "Country")
            {
                country.Text = "";
                country.ForeColor = Color.Black;
            }
        }

        private void country_Leave(object sender, EventArgs e)
        {
            if (country.Text == "")
            {
                country.Text = "Country";
                country.ForeColor = Color.Silver;
            }
        }

        private void email_Enter(object sender, EventArgs e)
        {
            if (email.Text == "Email ID")
            {
                email.Text = "";
                email.ForeColor = Color.Black;
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (email.Text == "")
            {
                email.Text = "Email ID";
                email.ForeColor = Color.Silver;
            }
        }

        private void phone_Enter(object sender, EventArgs e)
        {
            if (phone.Text == "Phone Number")
            {
                phone.Text = "";
                phone.ForeColor = Color.Black;
            }
        }

        private void phone_Leave(object sender, EventArgs e)
        {
            if (phone.Text == "")
            {
                phone.Text = "Phone Number";
                phone.ForeColor = Color.Silver;
            }
        }

        private void title_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void lname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void city_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void province_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void country_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            title.Clear();
            fname.Clear();
            lname.Clear();
            address.Clear();
            postalcode.Clear();
            city.Clear();
            province.Clear();
            country.Clear();
            email.Clear();
            phone.Clear();
            MessageBox.Show("Fields have been cleared");
        }

        private void email_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            bool isValid = regex.IsMatch(email.Text.Trim());
            if (!isValid)
            {
                MessageBox.Show("Invalid Email.");
            }
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
