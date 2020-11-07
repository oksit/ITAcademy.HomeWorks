using System;

namespace HW04.Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВВедите символ или W, или S, или A, или D");

            char userSymbol = Convert.ToChar(Console.ReadLine().ToLower());

            switch (userSymbol)
            {
                case 'a': Console.WriteLine("необходимо переместить фигуру влево"); break;
                case 'w': Console.WriteLine("необходимо переместить фигуру вверх"); break;
                case 'd': Console.WriteLine("необходимо переместить фигуру вправо"); break;
                case 's': Console.WriteLine("необходимо переместить фигуру вниз"); break;
                default: Console.WriteLine("вы ввели неверный символ"); break;

            }
        
        }
    }
}
