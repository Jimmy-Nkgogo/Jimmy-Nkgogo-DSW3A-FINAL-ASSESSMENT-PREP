using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;

namespace DataLayer
{
    public class dataClass
    {
        public void writeToFile(string email, string phoneNumber, string validPassword)
        {
            using (StreamWriter writer = new StreamWriter("Employee.txt", true))
            {
                writer.WriteLine($"{email}\t{phoneNumber}\t{validPassword}");
            }
        }
        public string[] readFromFile()
        {
            return File.ReadAllLines("Employee.txt");
        }
    }
}
