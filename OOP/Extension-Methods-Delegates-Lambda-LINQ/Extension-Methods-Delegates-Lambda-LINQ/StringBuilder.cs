namespace Extension_Methods_Delegates_Lambda_LINQ
{
    using System;
    using System.Collections.Generic;

    public static class StringBuilder
    {
        public static string SubString(this string str, int indexFrom)
        {
            List<char> stringOfChars = new List<char>();

            for (int i = indexFrom; i < str.Length; i++)
            {
                stringOfChars.Add(str[i]);
            }

            return string.Join(string.Empty, stringOfChars);
        }

        public static string SubString(this string str, int indexFrom, int length)
        {
            List<char> stringOfChars = new List<char>();

            for (int i = indexFrom; i < indexFrom + length; i++)
            {
                stringOfChars.Add(str[i]);
            }

            return string.Join(string.Empty, stringOfChars);
        }
    }
}
