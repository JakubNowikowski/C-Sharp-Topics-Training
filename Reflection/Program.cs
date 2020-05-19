using System;
using System.Reflection;

namespace Reflection
{

//////////      Źródło:https://www.plukasiewicz.net/Csharp_dla_zaawansowanych/Refleksja

    #region GetAttribute by reflection
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        System.Reflection.MemberInfo info = typeof(MyClassToGetAttributeInfo);
    //        // pobranie listy atrybutów
    //        object[] attributes = info.GetCustomAttributes(true);
    //        for (int i = 0; i < attributes.Length; i++)
    //        {
    //            // Wypisujemy wszystkie atrybuty
    //            Console.WriteLine(attributes[i]);
    //            // Dodatkowo uzyskamy dostęp do opisu naszego atrybutu
    //            ExampleAttribute ea = (ExampleAttribute)attributes[i];
    //            Console.WriteLine("Info: {0}", ea.message);
    //        }
    //        Console.ReadKey();
    //        // Wynik działania programu
    //        // Refleksja.ExampleAttribute
    //        // Info: Informacja o mojej klasie
    //    }
    //}

    //[AttributeUsage(AttributeTargets.All)]
    //public class ExampleAttribute : Attribute
    //{
    //    public readonly string message;
    //    private string topic;
    //    public ExampleAttribute(string Message)
    //    {
    //        this.message = Message;
    //    }
    //    public string Topic
    //    {
    //        get
    //        {
    //            return topic;
    //        }
    //        set
    //        {
    //            topic = value;
    //        }
    //    }
    //}
    //[ExampleAttribute("Informacja o mojej klasie")]
    //class MyClassToGetAttributeInfo
    //{
    //}
    #endregion

    #region Use method by reflection

    class Program
    {
        static void Main(string[] args)
        {
            var dog = Activator.CreateInstance(typeof(Dog)) as Dog;
            // Dostęp do właściowości klasy
            PropertyInfo[] properties = dog.GetType().GetProperties();
            PropertyInfo prep1 = properties[0];
            PropertyInfo prep2 = properties[1];
            // Ustawiamy wartość poszczególnych pól
            prep1.SetValue(dog, 3);
            prep2.SetValue(dog, "wilczur");
            // Wyświetlenie tych wartości
            Console.WriteLine(prep1.GetValue(dog, null));
            Console.WriteLine(prep2.GetValue(dog, null));
            // Dostęp do konstruktora
            var defaultConstr = typeof(Dog).GetConstructor(new Type[0]);
            var paramConstr = typeof(Dog).GetConstructor(new[] { typeof(int) });
            // Wywołanie konstruktorów
            var defConstrTest = (Dog)defaultConstr.Invoke(null);
            var secConstrTest = (Dog)paramConstr.Invoke(new object[] { 45 });
            // Wyświetlenie wartości po wywołaniu konstruktorów
            Console.WriteLine("Pierwszy konstruktor, liczba nóg: {0}", defConstrTest.NumberOfLegs);
            Console.WriteLine("Drugi konstruktor, liczba nóg: {0}", secConstrTest.NumberOfLegs);
            // Dostęp do metod
            var TestMethod = typeof(Dog).GetMethod("SetDogsBread");
            var InvokeMethod = (Dog)TestMethod.Invoke(dog, new object[] { "Mieszaniec" });
            Console.ReadKey();

            // Wynik działania programu
            // 3
            // wilczur
            // Pierwszy konstruktor, liczba nóg: 0
            // Drugi konstruktor, liczba nóg: 45
            // Refleksja! - Rasa psa: Mieszaniec
        }
    }
    class Dog
    {
        public int NumberOfLegs { get; set; }
        public string Breed { get; set; }
        public Dog()
        {
        }
        public Dog(int number)
        {
            NumberOfLegs = number;
        }
        public void SetDogsBread(string breed)
        {
            this.Breed = breed;
            Console.WriteLine("Refleksja! - Rasa psa: {0}", breed);
        }
        public void SetLegsNumber(int number)
        {
            this.NumberOfLegs = number;
        }
        public void Display()
        {
            Console.Write("Liczba nóg: {0}", NumberOfLegs);
            Console.WriteLine("Rasa psa: {0}", Breed);
        }
    }

    #endregion
}
