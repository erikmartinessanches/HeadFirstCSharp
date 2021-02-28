using System;
using System.Collections.Generic;
using System.Text;

//Treat any reference as a non-nullable reference type.
#nullable enable

namespace Chapter_11_examples
{
    class Guy
    {
        private string? Name { get; set; } //Name is now a nullable reference type...
        public int Age { get; set; }
        public override string ToString() => $"a {Age}-year-old named {Name}";

        public Guy(int age, string name)
        {
            Age = age;
            Name = name; //Preventing Name from being set to null.
        }
    }

}
