using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Question_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int total;

        private void radioButtonSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSmall.Checked == true)
            {
                total = 20;
            }
            else
            {
                total = 0;
            }
            labelDisplay.Text = total.ToString();    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMedium.Checked)
            {
                total = 35;
            }
            else
            {
                total = 0;
            }
            labelDisplay.Text = total.ToString();
        }

        private void radioButtonLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLarge.Checked)
            {
                total = 55;
            }
            else
            {
                total = 0;
            }
            labelDisplay.Text = total.ToString();
        }

        private void radioButtonThick_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
