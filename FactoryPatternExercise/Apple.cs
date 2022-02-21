using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class Apple : ILaptop
    {
        public void Build()
        {
            Console.WriteLine($"Building a new Apple laptop");
        }

        public void Memory()
        {
            Console.WriteLine($"This laptop has 128GB of SSD storage");
        }

        
    }
}
