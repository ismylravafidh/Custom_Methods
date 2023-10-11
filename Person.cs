using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        public string fullname { get; set; }
        public int age { get; set; }
        public string  phonenumber { get; set; }

        public Person(string FullName, int Age , string PhoneNumber)
        {
            fullname = FullName;
            age = Age;
            phonenumber = PhoneNumber;
        }
        
    }
}
