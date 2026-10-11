using System;
using System.Collections.Generic;
using System.Text;

namespace Route.OOP05.ExtensionMethods
{
    // class must be static => the all extension method should be also static
    //
    internal static class IntExtensions
    {
        // objectCaller.Method();
        // int number => number.IsEven();
        // IsEven(number)
        public static bool IsEven(this int number)
        {
            return number % 2 == 0 ? true : false;
        }
    }
}
