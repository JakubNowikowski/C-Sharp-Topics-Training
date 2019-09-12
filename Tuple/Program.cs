using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var tuple = (name: "john", age: 25);

            Console.WriteLine("tuple: " + tuple);

            tuple = SomeFunction();

            Console.WriteLine("changed tuple: " + tuple);

            //deconstruction

            Console.WriteLine("\ndeconstruction:");

            (var name, var age) = tuple;

            Console.WriteLine("name: " + name);
            Console.WriteLine("age: " + age);


            //avoiding out parameters by using tuple

            Console.WriteLine("\navoiding out parameters by using tuple:");

            bool hasChanged = false;

            string desc;

            hasChanged = ChangeBothWithOut(hasChanged, out desc);

            Console.WriteLine("\n");
            Console.WriteLine("hasChanged: " + hasChanged);
            Console.WriteLine("desc: " + desc);

            (hasChanged, desc) = ChangeBothWithTuple(hasChanged, desc);

            Console.WriteLine("\n");
            Console.WriteLine("hasChanged: " + hasChanged);
            Console.WriteLine("desc: " + desc);

            Console.ReadKey();
        }
        public static (string, int) SomeFunction()
        {
            return ("bob", 10);
        }

        private static (bool a, string b) ChangeBothWithTuple(bool a, string b)
        {
            return (true, "Changed both using tuple & deconstruction");
        }
        
        private static bool ChangeBothWithOut(bool a, out string b)
        {
            a = true;
            b = "Changed both using out";
            return a;
        }
    }
}
