using System;
using Xunit;

namespace System.Useful.NetStandard.Test
{
    public class DateAndTimeExtensionsTests
    {
    	[Fact]
        public void TestBetween()
        {
            var d1 = new DateTime(2010, 02, 01);
            var d2 = new DateTime(2011, 02, 01);
            var dStart = new DateTime(2010, 01, 01);
            var dEnd = new DateTime(2010, 12, 31);

            Assert.True(d1.IsBetween(dStart, dEnd));
            Assert.False(d2.IsBetween(dStart, dEnd));
        }
    }
}