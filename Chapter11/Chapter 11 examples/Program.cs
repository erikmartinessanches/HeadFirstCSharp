using System;

namespace Chapter_11_examples
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 1;
            var guy = new Guy() { Name = "Joe", Age = 26 };
            Console.WriteLine("i is {0} and guy is {1}", i, guy);
            ModifyAnIntAndGuy(ref i, ref guy);
            Console.WriteLine("Now i is {0} and guy is {1}", i, guy);
        }

        /* A "ref" parameter is like an "out" parameter, except that it doesn't 
        * need to be assigned prior to calling the function with the ref and it must
        * be assigned before the method returns.
        */
        static void ModifyAnIntAndGuy(ref int valueRef, ref Guy guyRef)
        {
            valueRef += 10;
            guyRef.Name = "Bob";
            guyRef.Age = 37;
        }
        /* Remember that value types have a TryParse method that uses "out" parameters.
         * For example: double.TryParse() and Enum.TryParse().
         */
    }
}
