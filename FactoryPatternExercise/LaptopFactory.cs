using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class LaptopFactory
    {
        public static ILaptop BuildLaptop()
        {
            Console.WriteLine($"How much GB storage do you need? 128GB or 256GB?");

            var answer = Console.ReadLine();


            if (answer.ToLower() == "128gb")
            {
                return new Apple();
            }
            else if (answer.ToLower() == "256gb")
            {
                return new Dell();
            }
            else
            {
                return new Dell();
            }
        }
        
    }
}
