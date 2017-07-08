using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Input_validator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtName.Text, @"^([A-Za-z]*\s*)*$"))
                MessageBox.Show("The name is invalid (only alphabetical characters are allowed)");


            if (!Regex.IsMatch(txtPhone.Text, @"^((\(\d{3}\)?)|(\d{3}-))?\d{3}-\d{4}$"))
                MessageBox.Show("The phone number is not a valid US phone number");

            if (!Regex.IsMatch(txtEmail.Text, @"^([a-zA-Z0-9_\-” +
        @”\.]+)@((\[[0-9]{1,3}" +
                @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
                MessageBox.Show("The e-mail address is not valid.");
        }
    }
}
