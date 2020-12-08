using System;
using System.Collections.Generic;
using System.Text;

namespace HW_11_Task3
{
    class StoreItem
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public string Category { get; set; }
        public double Size { get; set; }

        public StoreItem(string name, int code, string category, double size)
        {
            Name = name;
            Code = code;
            Category = category;
            Size = size;
        }
    }
}
