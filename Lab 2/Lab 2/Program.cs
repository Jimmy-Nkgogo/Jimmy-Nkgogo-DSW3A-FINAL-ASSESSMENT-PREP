﻿using System;
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
            while (true)
            {
                if (option == 1)
                {
                    try
                    {
                        string[] lines = DisplayAllData();
                        foreach (var item in lines)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (option == 2)
                {
                    try
                    {
                        Console.Write("Enter the year: ");
                        int year = int.Parse(Console.ReadLine());
                        string[] lines = DisplayYearData(year);
                        foreach (var line in lines)
                        {
                            Console.WriteLine(line);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (option == 3)
                {
                    try
                    {
                        Console.Write("Enter the car brand");
                        string userInput = Console.ReadLine();
                        string[] lines = DisplayBrandData(userInput);
                        foreach (var line in lines)
                        {
                            Console.WriteLine(line);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
                else if (option == 0)
                {
                    Console.WriteLine("Good ~ bye");
                    break;
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
        static string[] DisplayYearData(int year)
        {
            string[] lines = DisplayAllData();
            List<string> yearData = new List<string>();
            foreach (var line in lines)
            {
                string[] arrayLine = line.Split(',');
                if (int.Parse(arrayLine[0])  == year)
                {
                    yearData.Add(line);
                }
            }
            return yearData.ToArray();
        }
        static string[] DisplayBrandData(string carBrand)
        {
            string[] lines = DisplayAllData();
            List<string> brandData = new List<string>();
            foreach (var line in lines)
            {
                string[] arrayLine = line.Split(',');
                if (arrayLine[1].ToLower() == carBrand.ToLower())
                {
                    brandData.Add(line);
                }
            }
            return brandData.ToArray();
        }
    }
}
