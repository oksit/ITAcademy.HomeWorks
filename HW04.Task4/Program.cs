using System;

namespace HW04.Task4
{
    class Program
    {
        static int Sum(int numberA, int numberB)//метод суммы двух чисел
        {
            int resOfSum = numberA + numberB;
            return resOfSum;
        }

        static void CheckSum(int numberUser, int resOfSum) //метод проверки правильности вычисления суммы чисел
        {
            if (resOfSum == numberUser) { Console.WriteLine("Правильно!"); } //вывод верного результата вычисления
            else if (resOfSum > numberUser) { Console.WriteLine("Неправильно, должно быть больше");  }
            else Console.WriteLine("Неправильно, должно быть меньше");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое целое число:");//запрос числа 1

            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе целое число:");//запрос числа 2

            int number2 = Convert.ToInt32(Console.ReadLine());

            int resultOfSum = Sum(number1, number2);

            Console.WriteLine("Напишите сумму этих чисел");//запрос результата вычисления

            int userResOfSum = Convert.ToInt32(Console.ReadLine());

            CheckSum(userResOfSum, resultOfSum);

        }
    }
}
