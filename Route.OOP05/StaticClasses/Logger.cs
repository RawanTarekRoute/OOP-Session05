using System;
using System.Collections.Generic;
using System.Text;

namespace Route.OOP05.StaticClasses
{
    // helper class
    // utility class
    // container contain some helper functions
    internal static class Logger
    {
        public static void LogError(string message)
        {
            Console.WriteLine($"[ERROR]: {message}");
        }
        public static void LogWarning(string message)
        {
            Console.WriteLine($"[WARNING]: {message}");
        }
    }
}
