using System;
using System.Collections.Generic;
using System.Text;

namespace HW_11_Task3
{
    class Music : StoreItem, IPlay
    {
        public string Singer { get; set; }

        public int Length { get; set; }

        public Music (string name, int code, string category, double size, string singer, int length)
            :base(name,code,category,size)
        {
            Singer = singer;
            Length = length;
        }
        public void Play() { Console.WriteLine("Method Play of Music"); }
        public void RetrieveInformation() { Console.WriteLine("Method RetrieveInformatio of Music"); }
    }
}
