using System;

namespace StringExtensions
{
    public static class StringExtensions
    {
        public static string Title(this string text)
        {
            return text.Substring(0, 1).ToUpper() + text.Substring(1).ToLower();
        }
    }
}
