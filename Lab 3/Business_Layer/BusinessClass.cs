using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Layer;

namespace Business_Layer
{
    public class BusinessClass
    {
        private string _name;
        private string _surname;
        private string _email;
        private int _age;

        DataLayer dataClass = new DataLayer();
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string generateEmail(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Email = $"{Name[0]}{Surname}@uj.ac.za".ToLower();
            return Email;
        }
        public int GetAge(string userId)
        {
            string id = userId;
            string bornYear;
            int year = int.Parse(id.Substring(0, 2));
            DateTime date = DateTime.Now;

            if (year >= 0 && year <= 9)
            {
                if (year < 22)
                {
                    bornYear = $"200{year}";
                }
                else
                {
                    bornYear = $"19{year}";
                }
            }
            else
            {
                if (year < 22)
                {
                    bornYear = $"20{year}";
                }
                else
                {
                    bornYear = $"19{year}";
                }
            }

            int age = date.Year - int.Parse(bornYear);

            Age = age;

            return age;
        }
        public void WriteToFile()
        {
            dataClass.WriteToFile(Name, Surname, Email, Age);
        }
        public string[] ReadFile()
        {
            return dataClass.ReadFile();
        }
    }
}
