using System;
using System.Collections.Generic;
using System.Text;

namespace HW_11_Task_2
{
    class Person : IData
    {
        public string Name { get; set; } = "Tom";
        public void ShowData()
        {
            Console.Write("I'm a person my name is {0} and I live in ", this.Name);
        }
    }
}
