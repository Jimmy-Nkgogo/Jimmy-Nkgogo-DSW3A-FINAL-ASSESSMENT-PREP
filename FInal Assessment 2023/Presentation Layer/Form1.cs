using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void buttonValidate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxName.Text) && String.IsNullOrWhiteSpace(textBoxSurname.Text) && String.IsNullOrWhiteSpace(textBoxPhoneNumber.Text) && String.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Fill in all required textboxes");
            }
            else
            {
                string password = textBoxPassword.Text;
                
            }
        }
    }
}
