using System;
using System.Collections.Generic;
using System.Text;

namespace HW_11_Task3
{
    class Films : StoreItem, IPlay
    {
        public string Director { get; set; }

        public string MainActor { get; set; }

        public string MainActress { get; set; }

        public Films(string name, int code, string category, double size, string director, 
            string mainactor, string mainactress)
            : base(name, code, category, size)
        {
            Director = director;
            MainActor = mainactor;
            MainActress = mainactress;
        }

        public void Play() { Console.WriteLine("Method play of Films"); }
        public void RetrieveInformation() { Console.WriteLine("Method RetrieveInformation of Films"); }
    }
}
