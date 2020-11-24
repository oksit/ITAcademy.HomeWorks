using System;
using System.Text;
using System.Text.RegularExpressions;

namespace HW_Task8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userString = "gdfgdf234dg54gf*23oP42";
            Console.WriteLine(userString);
            int signMult = userString.IndexOf('*');//15
            
            StringBuilder sb = new StringBuilder(userString);

            string s1 = sb.ToString(0, 14);
            s1 = Regex.Replace(s1, @"[^\d]", "", RegexOptions.Compiled);
            Console.WriteLine(s1);
            int number1 = Convert.ToInt32(s1);

            string s2 = sb.ToString(16, 6);
            s2 = Regex.Replace(s2, @"[^\d]", "", RegexOptions.Compiled);
            Console.WriteLine(s2);
            int number2 = Convert.ToInt32(s2);

            Console.WriteLine($"{number1}*{number2} = "+ number1 * number2);
        }
    }
}
