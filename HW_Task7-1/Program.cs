using System;
using System.Dynamic;
using System.Text.RegularExpressions;

namespace HW_Task7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стихотворение, разделяя строки точкой с запятой - ;");

            string userInput = Console.ReadLine().ToUpper();

            string[] splitArray = userInput.Split(';');

            Console.WriteLine("Нажмите 2 раза Enter");

            if (Regex.IsMatch(Console.ReadLine(), "^[А-Я]*$"))
                for (int i = 0; i < splitArray.Length; i++)
                {
                    splitArray[i] = splitArray[i].Replace("О", "А");
                }

            if (Regex.IsMatch(Console.ReadLine(), "^[A-Z]*$"))
                for (int i = 0; i < splitArray.Length; i++)
                {
                    splitArray[i] = splitArray[i].Replace("O", "A");
                }

            Console.WriteLine("После замены о на а:\n");

            foreach (var item in splitArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
