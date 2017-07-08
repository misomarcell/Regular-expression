using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Reformat_a_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtOutput.Text = ReformatPhone(txtInput.Text);
        }

        static string ReformatPhone(string s)
        {
            Match m = Regex.Match(s, @"^\(?(\d{3})\)?[\s\-]?(\d{3})\-?(\d{4})$");

            return String.Format("({0}) {1}-{2}",
                                m.Groups[1],
                                m.Groups[2],
                                m.Groups[3]);
        }
    }
}
