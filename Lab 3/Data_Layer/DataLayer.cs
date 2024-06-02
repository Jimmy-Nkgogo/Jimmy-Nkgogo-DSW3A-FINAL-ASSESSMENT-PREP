using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Data_Layer
{
    public class DataLayer
    {

        public void WriteToFile(string name, string surname, string email, int age)
        {

            using (StreamWriter writer = new StreamWriter("Staff.txt", true))
            {
                writer.WriteLine($"{name}\t{surname}\t{email}\t{age}");
            }
        }
        public string[] ReadFile()
        {
            return File.ReadAllLines("Staff.txt");
        }
    }
}
