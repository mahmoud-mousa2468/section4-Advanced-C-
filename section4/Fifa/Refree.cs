using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section4.Fifa
{
    internal class Refree
    {
        public string Name { get; set; }
        // Call Back Function
        public void Look(Ball ball)
        {
            Console.WriteLine($"Refree {Name} Follow Ball {ball}");
        }
        public override string ToString()
        {
            return $"Refree Name : {Name}";
        }
    }
}
