﻿using System;

namespace ExtentionMethodsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            OrdinaryHuman steve = new OrdinaryHuman(185);
            Console.WriteLine(steve.BreakWalls(89.2));
        }
    }
}
