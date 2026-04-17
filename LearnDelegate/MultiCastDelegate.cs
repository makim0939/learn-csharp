using System;
using System.Collections.Generic;
using System.Text;

namespace LearnDelegate
{
    internal class MultiCastDelegate
    {
        public delegate void Greet(string message);

        public static void Run()
        {
            Greet greet = (string message) => Console.WriteLine($"Hello {message}");
            greet += (string message) => Console.WriteLine($"こんにちは {message}");
            greet += (string message) => Console.WriteLine($"Hola {message}");

            greet("たかし");
        }
    }
}
