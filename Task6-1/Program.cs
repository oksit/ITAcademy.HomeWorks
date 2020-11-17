using System;

namespace Task6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задача 1
            Необходимо: заполнить один массив случайными числами (для получения случайных чисел в C# есть 
            класс Random. В данном классе есть метод Next, который поможет получить рандомное число), 
            другой - введенными с клавиатуры числами, в элементы третьего записать суммы соответствующих 
            элементов первых двух. Содержимое массивов вывести на консоль.
            Дополнение: Все три массива должны иметь одинаковую размерность и тип*/

            #region First array

            int[] array1 = new int[5];

            Random rand = new Random();

            Console.Write("First array is: ");

            for (int x = 0; x < array1.Length; x++) 
            {
                array1[x] = rand.Next(1,21);
                Console.Write(array1[x] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("---");

            #endregion

            #region Second array

            int[] array2 = new int[5];
            
            for (int x = 0; x < array2.Length; x++)
            {
                Console.WriteLine($"Enter {x} element of second array");
                int userElement = Convert.ToInt32(Console.ReadLine());
                array2[x] = userElement;
            }

            Console.Write("Second array is: ");

            foreach (int k in array2) 
            { 
                Console.Write(k + " "); 
            }

            Console.WriteLine();

            Console.WriteLine("---");

            #endregion

            #region Third array

            int[] array3 = new int[5];

            Console.Write("Third array is: ");

            for (int x = 0; x < array3.Length; x++)
            {
                array3[x] = array1[x] + array2[x];
                Console.Write(array3[x] + " ");
            }

            Console.WriteLine();

            #endregion
        }
    }
}
