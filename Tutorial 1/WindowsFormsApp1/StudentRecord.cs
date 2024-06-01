using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    internal class StudentRecord
    {
        public List<Student> Students { get; set; }
        public StudentRecord()
        {
            Students = new List<Student>();
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public void WriteToFile()
        {
            using (StreamWriter writer = new StreamWriter(@"exam.txt", true))
            {
                string resultCode = "";
                foreach (var item in Students)
                {
                    resultCode = item.finalMark >= 50 ? "pass" : "fail";
                    writer.WriteLine($"{item.studentNumber}\t\t{item.finalMark}\t\t{resultCode}");
                }
            }
        }
    }
}
