using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class businessClass
    {
        private string _email;
        private bool _password;
        private string _phoneNumber;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public bool Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public bool ValidatePassword(string password)
        {
            int upperCaseCount = password.Count(char.IsUpper);
            if (upperCaseCount < 2)
                return false;

            int lowerCaseCount = password.Count(char.IsLower);
            if (lowerCaseCount < 2)
                return false;

            int digitCount = password.Count(char.IsDigit);
            if (digitCount < 2)
                return false;

            return true;
        }

        public string FormatNumber(string number)
        {
            string firstThree = number.Substring(0, 3);
            string secondThree = number.Substring(3, 3);
            string last = number.Substring(5);

            string formattedNumber = $"({firstThree}) {secondThree}-{last}";
            return formattedNumber;
        }

        public string generateEmail(string name,string surname)
        {
            return $"{name[0]}{surname}@uj.ac.za".ToLower();
        }

        public void writeToFile()
        {

        }

        public int generateAge(string userId)
        {
            string id = userId;
            string bornYear;
            int year = int.Parse(id.Substring(0, 2));

            DateTime date = DateTime.Now;

            if (year >= 0 && year <= 9)
            {
                if (year < 24)
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
                if (year < 24)
                {
                    bornYear = $"20{year}";
                }
                else
                {
                    bornYear = $"19{year}";
                }
            }

            int age = date.Year - int.Parse(bornYear);

            return age;
        }
    }
}
