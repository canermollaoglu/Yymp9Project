using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Product
    {
        public Product(string name)
        {
            ProductName = name; 
        }
        public int MyProperty { get; set; }
        public string? ProductName { get; set; }
        public double UnitPrice { get; set; }
    }
}
