using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = Options();
            while (option != 0)
            {
                if (option == 1)
                {
                    string[] lines = DisplayAllData();
                    foreach (var item in lines)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (option == 2)
                {
                    Console.WriteLine("Given year");
                }
                else if (option == 3)
                {
                    Console.WriteLine("Brand");
                }
                else if (option == 0)
                {
                    Console.WriteLine("Exit");
                }
                else
                {
                    Console.WriteLine("invalid option");
                }
                option = Options();
            }
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
        static string[] DisplayAllData()
        {
            string path = @"carData.csv";
            string[] lines = File.ReadAllLines(path);
            List<string> formattedLines = new List<string>();

            for (int i = 1; i < lines.Length; i++)
            {
                formattedLines.Add(lines[i]);
            }
            return formattedLines.ToArray();
        }
    }
}
