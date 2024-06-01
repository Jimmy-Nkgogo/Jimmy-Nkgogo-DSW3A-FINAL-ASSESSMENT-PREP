using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Data data = new Data();
        DataManager manager;
        int count;
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            count = 0;
            data = manager.getRecord(count);
            textBox1.Text = data.Number.ToString();
            textBox2.Text = data.Name;
            textBox3.Text = data.Surname;
            textBox4.Text = data.Email;
            textBox5.Text = data.IP;
            if (data.Gender == "Female")
            {
                radioButton1Female.Checked = true;
            }
            else
            {
                radioButtonMale.Checked = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            manager = new DataManager();
            manager.readFromFile();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            count += 1;
            data = manager.getRecord(count);
            textBox1.Text = data.Number.ToString();
            textBox2.Text = data.Name;
            textBox3.Text = data.Surname;
            textBox4.Text = data.Email;
            textBox5.Text = data.IP;
            if (data.Gender == "Female")
            {
                radioButton1Female.Checked = true;
            }
            else
            {
                radioButtonMale.Checked = true;
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                MessageBox.Show("Cannot go below 1");
            }
            else
            {
                count -= 1;
                data = manager.getRecord(count);
                textBox1.Text = data.Number.ToString();
                textBox2.Text = data.Name;
                textBox3.Text = data.Surname;
                textBox4.Text = data.Email;
                textBox5.Text = data.IP;
                if (data.Gender == "Female")
                {
                    radioButton1Female.Checked = true;
                }
                else
                {
                    radioButtonMale.Checked = true;
                }
            }
        }
    }
}
