using System;

namespace FactoryPatternExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var newLaptop = LaptopFactory.BuildLaptop();
            newLaptop.Build();
            newLaptop.Memory();

        }
    }
}
