using System;
using System.Xml.Linq;

namespace Sick_Test
{
    abstract class Student
    {
        protected int studentNumber;
        protected string name;
        protected string surname;
        public Student()
        {
            studentNumber = 0;
            name = null;
            surname = null;
        }
        public abstract void setStudent(int num, string n, string s);

        public abstract void displayStudent();
        
    }
    class ThirdYearStudent : Student
    {
        private string courseCode;
        private int assignment;
        private int test;

        public ThirdYearStudent()
        {
            
        }
        public override void setStudent(int num, string n, string s)
        {
            studentNumber = num;
            name = n;
            surname = s;
        }
        public void setStudent(int num, string n, string s, string CourseCode,int AssignmentMark,int TestMark)
        {
            studentNumber = num;
            name = n;
            surname = s;
            courseCode = CourseCode;
            assignment = AssignmentMark;
            test = TestMark;
        }
        public override void displayStudent()
        {
            Console.WriteLine("\n" + studentNumber + " " + name + " " + surname + $"{courseCode} {test} {assignment}");
        }
    }
}
