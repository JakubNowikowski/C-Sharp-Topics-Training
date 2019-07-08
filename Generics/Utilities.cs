namespace Generics
{
    class Utilities<T> where T : IBook
    {
        public string GetMaxSerialNumber(T a, T b)
        {
            return a.SerialNumber > b.SerialNumber ? a.Title : b.Title;
        }
    }
}
