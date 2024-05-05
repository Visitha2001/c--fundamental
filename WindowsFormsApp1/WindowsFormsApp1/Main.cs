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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calculator calculator = new calculator();
            calculator.MdiParent = this;
            calculator.Show();
        }

        private void bMIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grading grading = new Grading();
            grading.MdiParent = this;
            grading.Show();
        }
    }
}
