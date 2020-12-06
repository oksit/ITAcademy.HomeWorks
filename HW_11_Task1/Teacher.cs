using System;
using System.Collections.Generic;
using System.Text;

namespace HW_11_Task1
{
    class Teacher : Person
    {
        private string subject;
        public string Subject
        {
            set { subject = value; }
            get { return subject; }
        }
        public void Explain(string subject)
        {
            this.subject = subject;
            Console.WriteLine("Explanation of {0} begin", this.subject);
        }
        public Teacher() 
        { 
            Console.ForegroundColor = ConsoleColor.Green;
        }

    }
}
