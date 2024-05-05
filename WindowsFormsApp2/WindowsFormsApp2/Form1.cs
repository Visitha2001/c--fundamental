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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double hypo = Math.Sqrt((num1 * num1) + (num2 * num2));
            label3.Text = hypo.ToString();
        }
    }
}
