using System;
using System.Globalization;

namespace ObjLoader.Loader.Common
{
    public static class StringExtensions
    {
        public static float ParseInvariantFloat(this string floatString)
        {
            return float.Parse(floatString, CultureInfo.InvariantCulture.NumberFormat);
        }

        public static bool EqualsInvariantCultureIgnoreCase(this string str, string s)
        {
            return str.Equals(s, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}