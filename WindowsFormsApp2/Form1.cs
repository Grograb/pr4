using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                int a, b, c;
                bool rez1 = int.TryParse(textBox1.Text, out a);
                if (rez1 == false) 
                { 
                    MessageBox.Show("Неверный формат числа " + textBox1.Text + "!");
                    return; 
                }
                bool rez2 = int.TryParse(textBox2.Text, out b);
                if (rez2 == false) 
                { 
                    MessageBox.Show("Неверный формат числа " +textBox2.Text +"!");
                    return; 
                }
                c = (10* a+ 15*b)/2;
                string cStr = c.ToString();
                label2.Text = cStr;
                return; 
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
