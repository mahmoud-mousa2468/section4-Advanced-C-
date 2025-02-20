using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section4.Fifa
{
    internal class Player
    {
        public string Name { get; set; }
        public string TeamName { get; set; }
        // Call Back Function
        public void Run(Ball ball)
        {
            Console.WriteLine($"Player {Name} is running ..... at {ball}");
        }
        public override string ToString()
        {
            return $"PlayerName : {Name} :: TeamName : {TeamName}";
        }

    }
}
