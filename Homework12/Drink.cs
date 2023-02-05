using System;
using System.Collections.Generic;
using System.Text;

namespace Homework12
{
    public class Drink : Product
    {
        public double AlcoholPercent;

        public override void ShowInfo()
        {
            Console.WriteLine($"No-{No} Name: {Name} | Price: {Price} AZN | AlcoholPercent: {AlcoholPercent}%");
        }
    }
}
