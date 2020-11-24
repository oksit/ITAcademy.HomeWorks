using System;
using System.Text;

namespace HW_Task8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1a!2.3!!.. 4.!.?6 7! ..?";
            Console.WriteLine("Original string: " + str);
            Console.WriteLine();

            StringBuilder sb1 = new StringBuilder(str);
            StringBuilder sb2 = new StringBuilder(str);

            int firstQuesMark = str.IndexOf('?');//первое вхождение ? = 15
            int lastQuesMark = str.LastIndexOf('?');//второе вхождение ? = 23

            sb1.Remove(firstQuesMark, 9);
            Console.WriteLine("After remove the second part: " + sb1);
            Console.WriteLine();

            string s1 = sb1.ToString();//output 1a!2.3!!.. 4.!.
            sb1.Replace("!", String.Empty).Replace(".", String.Empty);
            Console.WriteLine("After removing '!' and '.' : \n" + sb1);
            Console.WriteLine();

            sb2.Remove(0, 16);//second part
            Console.WriteLine("After removing the first part: \n" + sb2);
            Console.WriteLine();

            sb2.Replace(' ', '_');
            Console.WriteLine("After replace whitespace to underscore: \n" + sb2);
        }
    }
}
