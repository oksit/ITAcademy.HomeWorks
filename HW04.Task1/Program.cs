using System;

namespace HW04.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год своего рождения:");

            int yeahOfBirth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите месяц своего рождения:");

            int monthOfBirth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите текущиий год :");

            int yeahOfNow = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите текущий месяц :");

            int monthOfNow = Convert.ToInt32(Console.ReadLine());

            int resultOfYeah = yeahOfNow - yeahOfBirth;

            if (monthOfBirth > monthOfNow) { Console.WriteLine("Вам сейчас "+(resultOfYeah-1)+"лет"); }

            else Console.WriteLine("Вам сейчас "+resultOfYeah+"лет");
            
        }
    }
}
