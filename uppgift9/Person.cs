using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift9
{
    class Person
    {
        string person { get; set; }
        int age { get; set; }
        public Person(string a, int b) 
        {
            person = a;
            age = b;
        }
        public int GetAge()
        {
            return age;
        }
    }
}
