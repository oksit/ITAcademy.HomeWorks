using AssemblyOne;
using System;


namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle moto2 = new Motorcycle();

            Console.WriteLine($"{moto2.modelPublic}");
        }
    }
}
