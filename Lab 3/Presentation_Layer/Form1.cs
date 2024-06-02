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
    }
}
