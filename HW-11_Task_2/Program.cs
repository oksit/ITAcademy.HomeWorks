using System;

namespace HW_11_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SmallApartment smalApart = new SmallApartment();
            Person person = new Person();

            person.ShowData();

            smalApart.ShowData();

            smalApart.GetDoor();
        }
    }
}
