using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class Dell : ILaptop
    {
        public void Build()
        {
            Console.WriteLine($"Building a new Dell laptop");
        }

        public void Memory()
        {
            Console.WriteLine($"This laptop has 256GB of SSD storage");
        }

    }
}
