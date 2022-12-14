using System;
using System.IO;
#nullable enable
namespace Chapter_11_examples
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 1;
            var guy = new Guy{ Age = 26, Name = "Joe"  };
            Console.WriteLine("i is {0} and guy is {1}", i, guy);
            ModifyAnIntAndGuy(ref i, ref guy);
            Console.WriteLine("Now i is {0} and guy is {1}", i, guy);


            using (var stringReader = new StringReader(""))
            {
                //Null-coalescing operator ??
                //?? returns an alternative if the checked value is null.
                var nextLine = stringReader.ReadLine() ?? String.Empty; //If stringReader.ReadLine is null, return an empty string.
                //??= assigns value only if the left operand is null, otherwise it leaves it intact.
                nextLine ??= "The first line was empty";
                Console.WriteLine("Line length is: {0}", nextLine.Length);
            }

            //Nullbale booleans can be declared like this
            Nullable<bool> optionalYesNoAnswer = null;
            //Or using a shortcut
            bool? anotherYesNoAnswer = false;
            //We can always convert a value type into a nullable type
            int? myNullableInt = 9321;
            //Getting the value back using the Value property of the nullable type
            int yeah = myNullableInt.Value; 
            /* T? is an alias for Nullable<T>
             The Value call casts the value with (int)myNullableInt and can throw an
             InvalidOperationException if the value is null. That's why Nullable<T> also
            has a HasValue property. We can also use the convenient GetValueOrDefault 
            method which safely returns a default value if the Nullable has no value. 
            We can optionally pass it a default value to use or use the type's normal
            default value.*/
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
