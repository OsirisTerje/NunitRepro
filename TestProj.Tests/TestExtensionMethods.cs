using System;
using System.Globalization;

namespace TestProj.Tests
{
    public static class TestExtensionMethods
    {
        private static readonly CultureInfo TestCulture = CultureInfo.GetCultureInfo("en-GB");

        public static DateTime ConvertToDateTime(this string date)
        {
            return Convert.ToDateTime(date, TestCulture);
        }
    }
}
