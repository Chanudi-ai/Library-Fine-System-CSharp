using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp30
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();





        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime due_date = DateTime.ParseExact(textBox1.Text.Trim(), "dd-MM-yyyy", null);
                DateTime today = DateTime.ParseExact(textBox2.Text.Trim(), "dd-MM-yyyy", null);

                int day = (today - due_date).Days;
                double fine;

                if (day < 1)
                {
                    MessageBox.Show("No Over due dates....,Good Standing.");
                }
                else if (day < 15)
                {
                    fine = day * 0.50;
                    if (0.01 < fine && fine < 11)
                    {
                        MessageBox.Show("Warning!!!");
                    }
                    MessageBox.Show("Fine Amount = " + fine);
                }
                else
                {
                    fine = day * 1.50;
                    if (fine < 25)
                    {
                        MessageBox.Show("Fine Amount =" + fine);
                    }
                    else
                    {
                        MessageBox.Show("Your account is Suspended...");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Date type : 20-10-2025");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
              try
            {
                DateTime due_date = DateTime.ParseExact(textBox1.Text.Trim(), "dd-MM-yyyy", null);
                DateTime Today = DateTime.ParseExact(textBox2.Text.Trim(), "dd-MM-yyyy", null);

                TimeSpan Over_Due = Today - due_date;
                int days = Over_Due.Days;

                if (days < 0) days = 0; 

                MessageBox.Show("Over due dates: " + days + " days");
            }
            catch
            {
                MessageBox.Show("Date,type : 20-10-2025");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    } 

