using System;
using System.Runtime.InteropServices;

namespace HW04.Task6
{
    class Program
    {
        
        static void Main(string[] args)
        {
            char[] array = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            for (int i = (array.Length) - 1; i >= 0; i--)
            { 
                Console.WriteLine(array[i]);
            }
        }    
    }
}
