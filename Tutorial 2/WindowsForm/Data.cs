using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm
{
    internal class Data
    {
        private int _number;
        private string _name;
        private string _surname;
        private string _email;
        private string _gender;
        private string _ip;

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
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
        public string IP
        {
            get { return _ip; }
            set { _ip = value; }
        }
    }
}
