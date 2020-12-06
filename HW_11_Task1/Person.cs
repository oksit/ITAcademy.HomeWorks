using System;
using System.Collections.Generic;
using System.Text;

namespace HW_11_Task1
{
    class Person
    {
        public int Age { set; get; }
        public int SetAge(int age)
        {
            Age = age;
            return age;
        }

        public void SayHello()
        {
            Console.WriteLine("Hello, this is {0}", this.ToString());
        }

        public Person()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}
