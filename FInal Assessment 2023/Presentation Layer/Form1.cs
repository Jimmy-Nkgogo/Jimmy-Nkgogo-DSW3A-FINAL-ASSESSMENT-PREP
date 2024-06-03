using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace Presentation_Layer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        businessClass business;
        private void buttonValidate_Click(object sender, EventArgs e)
        {
            business = new businessClass();
            if (String.IsNullOrWhiteSpace(textBoxName.Text) && String.IsNullOrWhiteSpace(textBoxSurname.Text) && String.IsNullOrWhiteSpace(textBoxPhoneNumber.Text) && String.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Fill in all required textboxes");
            }
            else
            {
                labelEmailDisplay.Text = business.generateEmail(textBoxName.Text, textBoxSurname.Text);
                textBoxPhoneNumber.Text = business.FormatNumber(textBoxPhoneNumber.Text);
                
                if (!business.ValidatePassword(textBoxPassword.Text))
                {
                    MessageBox.Show("Password is invalid");
                }
                else
                {
                    MessageBox.Show("Password is valid");
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                business.writeToFile();
                MessageBox.Show("Written to file....");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxPassword.Clear();
            textBoxPhoneNumber.Clear();
            labelEmailDisplay.Text = "";
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            string[] lines = business.readFromFile();
            string result = "";
            foreach (var line in lines)
            {
                result += line + Environment.NewLine;
            }
            textBox1.Text = result;
        }
    }
}
