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
        Data[] dataArray;
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

        private void radioButtonCom_CheckedChanged(object sender, EventArgs e)
        {
            dataArray = manager.determineDomain(radioButtonCom.Text);
            textBoxDisplay.Clear();
            string result = "";
            foreach (var data in dataArray)
            {
                result += $"{data.Number,-10}\t{data.Name,-20}\t{data.Surname,-25}\t{data.Email,-25}\t{data.Gender,-25}\t{data.IP}" + Environment.NewLine;
            }
            textBoxDisplay.Text = result;
        }

        private void radioButtonGov_CheckedChanged(object sender, EventArgs e)
        {
            dataArray = manager.determineDomain(radioButtonGov.Text);
            textBoxDisplay.Clear();
            string result = "";
            foreach (var data in dataArray)
            {
                result += $"{data.Number,-10}\t{data.Name,-20}\t{data.Surname,-25}\t{data.Email,-25}\t{data.Gender,-25}\t{data.IP}" + Environment.NewLine;
            }
            textBoxDisplay.Text = result;
        }

        private void radioButtonEdu_CheckedChanged(object sender, EventArgs e)
        {
            dataArray = manager.determineDomain(radioButtonEdu.Text);
            textBoxDisplay.Clear();
            string result = "";
            foreach (var data in dataArray)
            {
                result += $"{data.Number,-10}\t{data.Name,-20}\t{data.Surname,-25}\t{data.Email,-25}\t{data.Gender,-25}\t{data.IP}" + Environment.NewLine;
            }
            textBoxDisplay.Text = result;
        }

        private void radioButtonRu_CheckedChanged(object sender, EventArgs e)
        {
            dataArray = manager.determineDomain(radioButtonRu.Text);
            textBoxDisplay.Clear();
            string result = "";
            foreach (var data in dataArray)
            {
                result += $"{data.Number,-10}\t{data.Name,-20}\t{data.Surname,-25}\t{data.Email,-25}\t{data.Gender,-25}\t{data.IP}" + Environment.NewLine;
            }
            textBoxDisplay.Text = result;
        }

        private void radioButtonUk_CheckedChanged(object sender, EventArgs e)
        {
            dataArray = manager.determineDomain(radioButtonUk.Text);
            textBoxDisplay.Clear();
            string result = "";
            foreach (var data in dataArray)
            {
                result += $"{data.Number,-10}\t{data.Name,-20}\t{data.Surname,-25}\t{data.Email,-25}\t{data.Gender,-25}\t{data.IP}" + Environment.NewLine;
            }
            textBoxDisplay.Text = result;
        }

        private void radioButtonJp_CheckedChanged(object sender, EventArgs e)
        {
            dataArray = manager.determineDomain(radioButtonJp.Text);
            textBoxDisplay.Clear();
            string result = "";
            foreach (var data in dataArray)
            {
                result += $"{data.Number,-10}\t{data.Name,-20}\t{data.Surname,-25}\t{data.Email,-25}\t{data.Gender,-25}\t{data.IP}" + Environment.NewLine;
            }
            textBoxDisplay.Text = result;
        }
    }
}
