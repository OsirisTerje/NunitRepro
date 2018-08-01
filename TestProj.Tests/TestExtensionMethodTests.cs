using System;
using System.Globalization;
using NUnit.Framework;
using FluentAssertions;
using System.Threading;

namespace TestProj.Tests
{
    [TestFixture]
    public class TestExtensionMethodTests
    {
        [TestCase("en-GB")]
        [TestCase("en-US")]
        [TestCase("nb-NO")]
        [TestCase("nn-NO")]
        public void ConvertToDateTime_WithVaryingCulture_DayMonthYearFormat_ExpectSuccessfulConversion(string culture)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);

            var result = "5/10/2018".ConvertToDateTime();

            result.Should().BeSameDateAs(new DateTime(2018, 10, 5));
        }
    }
}
