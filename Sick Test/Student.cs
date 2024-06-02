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
        public double calcYearMark()
        {
            double yearMark = 0;
            yearMark = Math.Round((assignment * 0.45) + (test * 0.55), 2);
            return yearMark;
        }
        public double calcFinalMark()
        {
            double yearMark = calcYearMark();
            Random random = new Random();
            int exarmMark = random.Next(15, 86);
            double finalMark = 0;
            if (yearMark > 0)
            {
                finalMark = Math.Round((exarmMark + yearMark) / 2, 2);
            }
            else
            {
                return -1;
            }
            return finalMark;
        }
    }
}
