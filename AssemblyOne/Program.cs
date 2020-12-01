using System;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle moto = new Motorcycle();

            Console.WriteLine("Enter your model of motorcycle:");
            string userModel = Console.ReadLine();
            moto.ModelPrivate = userModel;

            Console.WriteLine($"This is Property - {moto.ModelPrivate}");
            Console.WriteLine($"{moto.modelInternal}");
            Console.WriteLine($"{moto.modelProtectedInternal}");
            Console.WriteLine($"{moto.modelPublic}");

            moto.DriveInternal();
            moto.AddGasPublic();
            moto.CleanProtectedInternal();

            SportBike sportbike = new SportBike();
            Console.WriteLine(sportbike.ModelPrivate);

        }
    }
}
