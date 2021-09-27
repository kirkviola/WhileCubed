using System;

namespace WhileCubed
{
    class Program
    {
        static void Main(string[] args)
        {
            // This loop will display the odd numbers 1 - 25 cubed.
            var BaseNumber = 1;
            while (BaseNumber <= 25)
            {
                if (BaseNumber % 2 == 0)
                { 
                    BaseNumber++;
                    continue;
                }
                
                Console.WriteLine($"{BaseNumber} cubed is {Math.Pow(BaseNumber, 3)}");
                BaseNumber++;
            }
            Console.WriteLine("");
            // Simpler way, this eliminates the need to check for even numbers.
            var OtherNumber = 1;
            while (OtherNumber <= 25)
            {
                Console.WriteLine(Math.Pow(OtherNumber, 3));
                OtherNumber += 2; // Why didn't I think of this.
            }
            Console.WriteLine("");

            // do ... while example
            var LastNumber = 1;
            do
            {
                Console.WriteLine($"The do cube is {Math.Pow(LastNumber, 3)}");
                LastNumber += 2;
            } while (LastNumber <= 25);

        }
    }
}
