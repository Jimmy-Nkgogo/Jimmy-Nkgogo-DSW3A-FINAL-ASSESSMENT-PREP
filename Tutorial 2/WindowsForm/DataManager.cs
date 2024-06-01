using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsForm
{
    internal class DataManager
    {
        private Data[] _dataList;

        public Data[] readFromFile()
        {
            string path = @"MOCK_DATA.csv";
            string[] lines = File.ReadAllLines(path);
            List<Data> dataList = new List<Data>();

            foreach (var line in lines)
            {
                string[] arrayLine = line.Split(',');
                int number = int.Parse(arrayLine[0]);
                dataList.Add(new Data 
                {
                    Number = number,
                    Name = arrayLine[1],
                    Surname = arrayLine[2],
                    Email = arrayLine[3],
                    Gender = arrayLine[4],
                    IP = arrayLine[5]
                });
            }
            _dataList = dataList.ToArray();
            return dataList.ToArray();
        }
        public Data[] determineDomain(string domain)
        {
            List<Data> domainList = new List<Data>();
            Data[] lines = readFromFile();
            foreach (var line in lines)
            {
                if (line.Email.ToLower().Contains(domain.ToLower()))
                {
                    domainList.Add(line);
                }
            }
            return domainList.ToArray();
        }
        public int getCounter(string domain)
        {
            Data[] lines = determineDomain(domain);
            return lines.Length;
        }
        public Data getRecord(int index)
        {
            Data[] lines = readFromFile();
            return lines[index];
        }
    }
}
