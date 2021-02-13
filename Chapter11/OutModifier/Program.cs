using System;

namespace OutModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number. ");
            //"Out" and "ref" parameters are passed by reference.
            //TryParse uses the "out" modifier to convert a string to an int.
            if (int.TryParse(Console.ReadLine(), out int input))
            {
                //We also need to use the "out" modifier when calling a method that takes "out" parameters.
                var output1 = ReturnThreeValues(input, out double output2, out int output3);
                Console.WriteLine($"Outputs: plus one = {output1}, half = {output2:F}, twice={output3}");
            }
        }

        //Returning more than one value by using "out" parameters.
        public static int ReturnThreeValues(int value, out double half, out int twice)
        {
            //All "out" parameters must be assigned before the method exits.
            half = value / 2f;
            twice = value * 2;
            return value + 1;
        }
    }
}
