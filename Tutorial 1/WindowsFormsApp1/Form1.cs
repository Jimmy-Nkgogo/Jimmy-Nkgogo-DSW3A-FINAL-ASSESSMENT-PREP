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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         You are requested to develop a C# application for out institution. The application determine
a student’s final mark based on the marks obtained from the assignment, test and
examination. The assignment, test, and exam has the weights of 20%, 30% and 50%
respectively. The captured user input and the computed final mark is stores in a data structure
such as an array of objects. The application must also save all students’ data in a “TXT” file
called exam.txt. The below diagrams illustrates the operations that that must performed 
         */
        private string studentNumber;
        private double assignmentMark;
        private double testMark;
        private double examMark;
        private double finalMark;
        private void buttonCompute_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxStudentNumber.Text) && String.IsNullOrWhiteSpace(textBoxAssignment.Text) && String.IsNullOrWhiteSpace(textBoxTest.Text) && String.IsNullOrWhiteSpace(textBoxExam.Text))
            {
                MessageBox.Show("Fill in the missing textbox");
            }
            else
            {
                studentNumber = textBoxStudentNumber.Text;
                assignmentMark = Convert.ToDouble(textBoxAssignment.Text);
                testMark = Convert.ToDouble(textBoxTest.Text);
                examMark = Convert.ToDouble(textBoxExam.Text);
                finalMark = Math.Round((assignmentMark * 0.2) + (testMark * 0.3) + (examMark * 0.5),2);
                textBoxFinal.Text = finalMark.ToString();
            }
        }

        private void textBoxStudentNumber_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxStudentNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
