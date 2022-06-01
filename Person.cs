using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220531_Homework
{
    internal class Person
    {
        public int Age { get; set; }
        private static int _age;
        public Person()
        {
            Age = ++_age;
        }
    }
}
