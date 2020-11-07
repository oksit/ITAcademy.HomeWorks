using System;

namespace HW04.Task2
{
    class Program
    {
        static int Sum(int numberA, int numberB)
        {
            int resOfSum = numberA + numberB;
            return resOfSum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое целое число:");

            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе целое число:");

            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сумма этих чисел = "+ Sum(number1,number2));
        }
    }
}
