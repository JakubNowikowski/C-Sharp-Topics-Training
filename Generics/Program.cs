using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Generic List

            //Console.WriteLine("*****");
            //GenericList<int> intList = new GenericList<int>();

            //for (int i = 3; i > 0; i--)
            //    intList.Add(i);

            //Console.WriteLine("\n=> Int list:");
            //foreach (int e in intList)
            //    Console.Write(e + " ");

            //Console.WriteLine("\n\n*****");
            //GenericList<string> stringList = new GenericList<string>();

            //stringList.Add("c");
            //stringList.Add("b");
            //stringList.Add("a");

            //Console.WriteLine("\n=>String list:");
            //foreach (string e in stringList)
            //    Console.Write(e + " ");

            //Console.WriteLine("\n\n*****");
            //GenericList<Book> bookList = new GenericList<Book>();

            //bookList.Add(new Book { SerialNumber = 3, Title = "Some Title 3" });
            //bookList.Add(new Book { SerialNumber = 2, Title = "Some Title 2" });
            //bookList.Add(new Book { SerialNumber = 1, Title = "Some Title 1" });

            //Console.WriteLine("\n=>Book list:");
            //foreach (Book e in bookList)
            //    Console.WriteLine($"Serial number: {e.SerialNumber}, Title: {e.Title}");

            //Console.WriteLine("\n*****");

            #endregion

            #region Generics with constraint

            //Book book1 = new Book { SerialNumber = 1, Title = "Some Title 1" };
            //Book book2 = new Book { SerialNumber = 2, Title = "Some Title 2" };

            //AdvantureBook advantureBook1 = new AdvantureBook { SerialNumber = 3, Title = "Some Title 3" };
            //AdvantureBook advantureBook2 = new AdvantureBook { SerialNumber = 4, Title = "Some Title 4" };

            //Utilities<Book> bookUtilities = new Utilities<Book>();

            //Utilities<AdvantureBook> advantureBookUtilities = new Utilities<AdvantureBook>();

            //var bookCompareResult = bookUtilities.GetMaxSerialNumber(book2, book1);

            //var advantureBookCompareResult = advantureBookUtilities.GetMaxSerialNumber(advantureBook2, advantureBook1);

            //Console.WriteLine(bookCompareResult);

            //Console.WriteLine(advantureBookCompareResult);

            #endregion

            Console.ReadKey();
        }
    }
}
