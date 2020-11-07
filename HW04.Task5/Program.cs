using System;

namespace HW04.Task5
{
    class Program
    {
        static int Sum(int numberA, int numberB)//метод суммы двух чисел
        {
            int resOfSum = numberA + numberB;
            return resOfSum;
        }
        static int Sub(int numberA, int numberB)//метод разности двух чисел
        {
            int resOfSub = numberA - numberB;
            return resOfSub;
        }
        static void CheckSum(int numberUser, int resOfSum) //метод проверки правильности вычисления суммы чисел
        {
            if (resOfSum == numberUser) { Console.WriteLine("Правильно!"); } //вывод верного результата вычисления
            else Console.WriteLine( "Неправильно!"); 
            if ((resOfSum != numberUser)&(resOfSum > numberUser)) { Console.WriteLine("должно быть больше"); }
            if ((resOfSum != numberUser) & (resOfSum < numberUser)) Console.WriteLine("должно быть меньше");
        }

        static void CheckSub(int numberUser, int resOfSub) //метод проверки правильности вычисления суммы чисел
        {
            if (resOfSub == numberUser) { Console.WriteLine("Правильно!"); } //вывод верного результата вычисления
            else Console.WriteLine("Неправильно!");
            if ((resOfSub != numberUser) & (resOfSub > numberUser)) { Console.WriteLine("должно быть больше"); }
            if ((resOfSub != numberUser) & (resOfSub < numberUser)) Console.WriteLine("должно быть меньше");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое целое число:");//запрос числа 1

            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе целое число:");//запрос числа 2

            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите оператор или суммы или разности");
            char userOperator = Convert.ToChar(Console.ReadLine());

            int resultOfSum = Sum(number1, number2);
            int resultOfSub = Sub(number1, number2);

            switch (userOperator)
            {
                case '+': Console.WriteLine("Введите сумму чисел"); break;
                case '-': Console.WriteLine("Введите разность чисел"); break;
                default: Console.WriteLine("Введите или + или - "); break;
            }

            if (userOperator == '+') 
            { 
            int userResOfSum = Convert.ToInt32(Console.ReadLine());
            CheckSum(userResOfSum, resultOfSum);
            }
            if (userOperator=='-')
            {
                int userResOfSub = Convert.ToInt32(Console.ReadLine());
                CheckSub(userResOfSub, resultOfSub); };
            }
    }
}
