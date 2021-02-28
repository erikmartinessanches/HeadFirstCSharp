using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingExtensions
{
    public static class ExtendAHuman
    {
        public static bool IsDistressCall(this string s)
        {
            return (s.Contains("Help!")) ? true : false;

        }
    }
}
