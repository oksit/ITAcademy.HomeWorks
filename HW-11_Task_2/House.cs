using System;
using System.Collections.Generic;
using System.Text;

namespace HW_11_Task_2
{
    class House : IData, IPart
    {
        private double area;
        public double Area
        {
            get { return area; }
            set { area = value; }
        }

        string IPart.DoorColor
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public House()
        { }
        public House(double a)
        {
            this.Area = a;
        }
        public void ShowData()
        {
            Console.WriteLine("this is house, my area is {0} sq.m", this.Area);
        }
        string DoorColor = "Green";
        public void GetDoor()
        {
            Console.WriteLine("The door of house {0} color", this.DoorColor);
        }
    }
}
