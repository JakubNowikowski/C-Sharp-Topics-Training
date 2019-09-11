using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? nullableDate = DateTime.Today;

            Console.WriteLine("GetValueOrDefault(): " + nullableDate.GetValueOrDefault());
            Console.WriteLine("HasValue: " + nullableDate.HasValue);
            Console.WriteLine("Value: " + nullableDate.Value); // throws exepction when value is null

            DateTime nonNullableDate = nullableDate.GetValueOrDefault();

            Console.WriteLine("nonNullableDate: " + nonNullableDate);

            // nullable coalescing operator

            nullableDate = null;

            nonNullableDate = nullableDate ?? new DateTime(966,1,2);

            //that gives the same result as the code below

            //if (nullableDate != null)
            //    nonNullableDate = nullableDate.GetValueOrDefault();
            //else
            //    nonNullableDate = DateTime.Today;

            Console.WriteLine("\nnullable coalescing operator");
            Console.WriteLine("nonNullableDate: " + nonNullableDate);

            Console.ReadKey();
        }
    }
}
