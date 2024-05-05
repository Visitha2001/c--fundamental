using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Grading : Form
    {
        public Grading()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(textBox1.Text);
            if (result >= 75 && result <= 100)
            {
                label3.Text = "A";
            }
            else if (result >= 65)
            {
                label3.Text = "B";
            }
            else if(result >= 55)
            {
                label3.Text = "C";
            }
            else if(result >= 35)
            {
                label3.Text = "S";
            }
            else if(result <= 35 && result >= 0)
            {
                label3.Text = "F";
            }
            else
            {
                label3.Text = "Invalid Input";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label3.Text = "0";
        }
    }
}
