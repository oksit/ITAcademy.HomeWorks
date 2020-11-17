using System;
using System.Linq;
using System.Diagnostics;

namespace Task6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            var stopwatch = Stopwatch.StartNew();

            Int64[] myArray = new Int64[100000000];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rand.Next(1,100);
                //Console.Write(myArray[i]+ " ");
            }
            Console.WriteLine();

            MyReverse(myArray);

            //Array.Reverse(myArray);

            long ticks1 = stopwatch.ElapsedTicks;
            Console.WriteLine(ticks1);

            //foreach (var item in myArray)
            //{
            //    Console.Write(item + " ");
            //}
        }
        
        static Int64[] MyReverse(Int64[] array) 
        {
            Int64 temp = 0;
            int longArr = array.Length;
            int sub = longArr - 1;
            for (int i = 0; i < sub; i++)
            {
                temp = array[i];
                array[i] = array[sub];
                array[sub] = temp;
                sub--;
            }

            return array;
        }
    }
}
