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
        private int small = 20;
        private int medium = 35;
        private int large = 55;
        private int topping = 7;
        private void radioButtonSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSmall.Checked == true)
            {
                total += small;
            }
            else
            {
                total -= small;
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
                total += medium;
            }
            else
            {
                total -= medium;
            }
            labelDisplay.Text = total.ToString();
        }

        private void radioButtonLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLarge.Checked)
            {
                total += large;
            }
            else
            {
                total -= large;
            }
            labelDisplay.Text = total.ToString();
        }

        private void radioButtonThick_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonThick.Checked)
            {
                total += 2;
            }
            else
            {
                total -= 2;
            }
            
            labelDisplay.Text = total.ToString();
        }

        private void radioButtonThin_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonThin.Checked)
            {
                total += 1;
            }
            else
            {
                total -= 1;
            }
            
            labelDisplay.Text = total.ToString();
        }

        private void checkBoxPepperoni_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPepperoni.Checked)
            {
                total += topping;
            }
            else
            {
                total -= topping;
            }
            labelDisplay.Text = total.ToString();
        }

        private void checkBoxJalapeno_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxJalapeno.Checked)
            {
                total += topping;
            }
            else
            {
                total -= topping;
            }
            labelDisplay.Text = total.ToString();

        }

        private void checkBoxSpinach_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSpinach.Checked)
            {
                total += topping;
            }
            else
            {
                total -= topping;
            }
            labelDisplay.Text = total.ToString();

        }

        private void checkBoxExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxExtraCheese.Checked)
            {
                total += topping;
            }
            else
            {
                total -= topping;
            }
            labelDisplay.Text = total.ToString();

        }

        private void checkBoxPineapple_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPineapple.Checked)
            {
                total += topping;
            }
            else
            {
                total -= topping;
            }
            labelDisplay.Text = total.ToString();
        }

        private void checkBoxShreddedChicken_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShreddedChicken.Checked)
            {
                total += topping;
            }
            else
            {
                total -= topping;
            }
            labelDisplay.Text = total.ToString();
        }

        private void checkBoxMushroom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMushroom.Checked)
            {
                total += topping;
            }
            else
            {
                total -= topping;
            }
            labelDisplay.Text = total.ToString();
        }

        private void checkBoxDriedShrimp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDriedShrimp.Checked)
            {
                total += topping;
            }
            else
            {
                total -= topping;
            }
            labelDisplay.Text = total.ToString();
        }

        private void checkBoxGroundedBeef_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGroundedBeef.Checked)
            {
                total += topping;
            }
            else
            {
                total -= topping;
            }
            labelDisplay.Text = total.ToString();
        }
    }
}
