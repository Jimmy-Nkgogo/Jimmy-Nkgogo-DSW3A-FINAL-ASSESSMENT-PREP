using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double price;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = "";
            textBoxName.Text = "";
            textBoxPrice.Text = "";
        }
        /*
         Design a C# application for Domicile Designs that get sales transaction data, including
customer name and purchase price. The store charges 25% interest on the purchase price.
Output the customer payment and customer’s projected balance each month up until the
entire amount is paid off. Assume that when the balance reached R15 or less, the customer
can pay off the account. The customer makes a payment of 12% of the price; inclusive of
interest.
         */
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxPrice.Text))
            {
                MessageBox.Show("Enter a price");
            }
            else
            {
                price = Convert.ToDouble(textBoxPrice.Text);
                price = price + (price * 0.25);
                while (price > 15)
                {
                    textBoxDisplay.Text += price.ToString() + Environment.NewLine;
                    price = price - (price * 0.12);
                }
            }
        }
    }
}
