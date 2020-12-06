using System;
using System.Collections.Generic;
using System.Text;

namespace HW_11_Task1
{
    class Student : Person
    {
        public Student()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        public void GoToClasses()
        {
            Console.WriteLine("I'm going to class");
        }

        public void ShowAge(int n)
        {
            Console.WriteLine("My age is: {0} years old", n);
        }

    }
}
