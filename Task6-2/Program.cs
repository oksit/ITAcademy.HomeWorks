using System;

namespace Task6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задача 2
            Необходимо: заполнить вводом с клавиатуры численный массив за исключением последнего 
            элемента, вывести его на экран. Запросить еще одно значение и его позицию в массиве. Вставить 
            указанное число в заданную позицию, подвинув элементы после него.*/

            int[] userArray = new int[5];

            for (int x = 0; x < userArray.Length-1; x++)
            {
                Console.WriteLine($"Enter {x} element of user array");
                int userElement = Convert.ToInt32(Console.ReadLine());
                userArray[x] = userElement;
            }

            Console.Write("User array is: ");

            foreach (int k in userArray)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();

            Console.WriteLine($"Enter integer element of array");

            int userNewElement = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Enter integer position of your array's element from 0 to 4");

            int userPositionOfElement = Convert.ToInt32(Console.ReadLine());

            if ((userPositionOfElement < 0) | (userPositionOfElement > 4)) 
            { 
                Console.WriteLine("You entered incorrect number");
            }

            switch (userPositionOfElement) 
            {
                case 0:
                    userArray[4] = userArray[3];
                    userArray[3] = userArray[2];
                    userArray[2] = userArray[1];
                    userArray[1] = userArray[0];
                    userArray[0] = userNewElement;
                    break;

                case 1:
                    userArray[4] = userArray[3];
                    userArray[3] = userArray[2];
                    userArray[2] = userArray[1];
                    userArray[1] = userNewElement;
                    break;

                case 2:
                    userArray[4] = userArray[3];
                    userArray[3] = userArray[2];
                    userArray[2] = userNewElement;
                    break;

                case 3:
                    userArray[4] = userArray[3];
                    userArray[3] = userNewElement;
                    break;

                case 4:
                    userArray[4] = userNewElement;
                    break;

                default:
                    Console.WriteLine("Incorrect position of array's element");
                    break;
            }

            foreach (int k in userArray)
            {
                Console.Write(k + " ");
            }
        }
    }
}
