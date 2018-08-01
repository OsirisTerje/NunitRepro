using System;
using System.Globalization;
using NUnit.Framework;
using FluentAssertions;
using System.Threading;
using TestProj.Infrastructure.Extensions;

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
            int x;
            Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);

            var result = "5/10/2018".ConvertToDateTime();
            x = 4;
            result.Should().BeSameDateAs(new DateTime(2018, 10, 5));
            //Assert.That(x,Is.EqualTo(4));
        }


        [Test]
        public void TestExtensionMethod()
        {
            string s = "a b c";
            var res = s.RemoveWhitespace();
            Assert.That(res,Is.EqualTo("abc"));
        }
    }
}
