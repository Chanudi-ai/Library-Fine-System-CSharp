using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string password = textBox2.Text;
            if (Name == "Admin" && password == "Admin@333")
            {
                MessageBox.Show("Login Success!!!...");
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Error!..");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
