using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_11_examples
{
    class Guy
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString() => $"a {Age}-year-old named {Name}";
    }
}
