using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sick_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ThirdYearStudent> thirdYearStudents = new List<ThirdYearStudent>();

            ThirdYearStudent thirdYear1 = new ThirdYearStudent();
            ThirdYearStudent thirdYear2 = new ThirdYearStudent();

            foreach (var student in thirdYearStudents)
            {
                student.displayStudent();
                Console.WriteLine(student.calcFinalMark());
            }
        }
    }
}
