using System;
using System.Collections.Generic;
using System.Text;

namespace Homework12
{
    public class Product
    {
        static int _totalCount;
        public Product()
        {
            _totalCount++;
            No = _totalCount;
        }

        public int No;
        public string Name;
        public double Price;

        public virtual void ShowInfo()
        {
            Console.WriteLine($"No-{No} Name: {Name} | Price: {Price} AZN");
        }

    }
}
