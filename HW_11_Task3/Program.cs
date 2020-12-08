using System;
using System.Linq;

namespace HW_11_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            StoreItem storeItem = new StoreItem("Kill Bill", 111, "fantastic", 1560.4);

            Films films = new Films("Kill Bill2", 112, "fantastic", 2000, "Tarantino", "Bruce", "Mila");

            Music music = new Music("Honesty", 113, "pop", 25, "Billy", 10);

            CompProgram compProgram = new CompProgram("Skype", 114, "massenger", 123);

            object[][] arr2 = new object[3][]
            {
            new object[]{ films.Name, films.Code, films.Category, films.Size, films.Director, films.MainActor, films.MainActress},
            new object[]{ music.Name, music.Code, music.Category, music.Size, music.Singer, music.Length},
            new object[]{ compProgram.Name, compProgram.Code, compProgram.Category, compProgram.Size}
            };

            foreach (var item in arr2)
            {
                Console.WriteLine(item.Aggregate((a, b) => a + " " + b));
            }
        }
    }
}
