using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        static int Options()
        {
            int option;
            Console.WriteLine("1: Display all data from the dataset");
            Console.WriteLine("2: Display all data based on the given year (2013 - 2018)");
            Console.WriteLine("3: Display all data based on the car brand (eg. BMW, Jeep)");
            Console.WriteLine("0: Exit...");
            option = Convert.ToInt32(Console.ReadLine());
            return option;
        }
    }
}
