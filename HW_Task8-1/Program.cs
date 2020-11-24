using System;
using System.Text;

namespace HW_Task8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1a!2.3!!.. 4.!.?6 7! ..?";
            Console.WriteLine(str.Length);//24
            Console.WriteLine(str.IndexOf('?'));
            Console.WriteLine(str.LastIndexOf('?'));
            StringBuilder sb = new StringBuilder(str);


            int firstVoprSine = str.IndexOf('?');//первое вхождение ? = 15
            int lastVoprSine = str.LastIndexOf('?');//второе вхождение = 23


            sb.Remove(0,16);
            Console.WriteLine(sb);
            String s2 = sb.ToString(6, 5); // s2 = "world"

            sb.Remove(firstVoprSine, 9);
            Console.WriteLine(sb);
            sb.Replace(' ', '_');
            Console.WriteLine(sb);
            //str.IndexOfAny()
            //sb.Remove
            //sb.Replace(' ', '_');
        }


    }
}
