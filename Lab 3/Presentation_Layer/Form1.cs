using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;

namespace Presentation_Layer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BusinessClass businessClass;
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxIdNumber.Text) && String.IsNullOrWhiteSpace(textBoxName.Text) && String.IsNullOrWhiteSpace(textBoxSurname.Text))
            {
                MessageBox.Show("Please fill in all the textboxes");
            }
            else
            {
                businessClass = new BusinessClass();
                labelEmail.Text= businessClass.generateEmail(textBoxName.Text,textBoxSurname.Text);
                
                labelAge.Text = businessClass.GetAge(textBoxIdNumber.Text).ToString();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxIdNumber.Clear();
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxDisplay.Clear();
            labelAge.Text = "";
            labelEmail.Text = "";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                businessClass.WriteToFile();
                MessageBox.Show("Written to file...");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            string[] lines = businessClass.ReadFile();
            textBoxDisplay.Text = "";
            string result = "";
            foreach (var line in lines)
            {
                result += line + Environment.NewLine;
            }
            textBoxDisplay.Text = result;
        }
    }
}
