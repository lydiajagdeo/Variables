using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Zeus";
            int dogAge = 3;
            char exclamation = '!';
            bool SaintBernard = true;
            double weight = 150.45;
            decimal drool = 1.4597320m;

            Console.WriteLine($"My dog's name was {dogName}, and he was {dogAge} years old. \n" +
            $"He was a gentle giant which was so {SaintBernard} and was {weight}lbs{exclamation}\n" +
            $"He left {drool} inches of slobber everywhere he went, and he is missed."); ;
        }
    }
}

