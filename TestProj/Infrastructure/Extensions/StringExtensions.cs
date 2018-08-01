using System;
using System.Linq;

namespace TestProj.Infrastructure.Extensions
{
    public static class StringExtensions
    {
        public static string RemoveWhitespace(this string input)
        {
            // todo: do anything here to trigger live unit testing
            //  To "fix" the problem once, stop live unit testing and delete / clear the folder .vs/project/lut
            //  This will allow the tests to execute once before it occurs again
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }
    }
}
