using System;

namespace System
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "a1b2c3";

            var convertedPost = post.RemoveDigits();

            Console.WriteLine(convertedPost);

            Console.ReadKey();
        }
    }
}