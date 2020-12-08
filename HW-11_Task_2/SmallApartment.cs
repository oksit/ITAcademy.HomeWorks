using System;
using System.Collections.Generic;
using System.Text;

namespace HW_11_Task_2
{
    class SmallApartment : House, IData, IPart
    {
        public SmallApartment() { Area = 50; }

        public new void ShowData() { Console.WriteLine("SmallApartment with area {0} sq.m", this.Area); }

        public string DoorColor = "Red";
        public new void GetDoor() { Console.WriteLine("The door of small apartment {0} color", this.DoorColor); }

    }
}
