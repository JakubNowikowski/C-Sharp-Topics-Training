namespace System
{
    public static class StringExtensions
    {
        public static string RemoveDigits(this String str)
        {
            string newStr = null;
            for (int i = 0; i < str.Length; i++)
                if (!char.IsNumber(str[i]))
                    newStr += str[i];
            return newStr;
        }
    }
}
