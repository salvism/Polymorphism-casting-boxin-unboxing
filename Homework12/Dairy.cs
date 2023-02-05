using System;
using System.Collections.Generic;
using System.Text;

namespace Homework12
{
    public class Dairy : Product
    {
        public double FatPercent;

        public override void ShowInfo()
        {
            Console.WriteLine($"No-{No} Name: {Name} | Price: {Price} AZN | FatPercent: {FatPercent}%");
        }
    }
}
