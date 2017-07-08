using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Convert_a_Text_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);

            if ( openFileDialog1.FileName != "")
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileExtension = new FileInfo(textBox1.Text).Extension;
            string fileName = new FileInfo(textBox1.Text).FullName;
            StreamReader sr = new StreamReader(fileName);
            StreamWriter sw = new StreamWriter(fileName.Replace(fileExtension, "") + "-utf7" + fileExtension, false, Encoding.UTF7);

            sw.WriteLine(sr.ReadToEnd());
            sw.Close();
            sr.Close();
        }
    }
}
