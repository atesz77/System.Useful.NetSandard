using System;
using Xunit;

namespace System.Useful.NetStandard.Test
{
    public class BoolExtensionsTests
    {
        //[Fact]
        //public void TestAnd()
        //{
        //    int x = 3;

        //    //Assert.True()
        //}

        [Fact]
        public void TestOr()
        {
            int x = 3;

            Assert.True(x.Or(1, 2, 3, 4));
            Assert.False(x.Or(1, 2, 4));
        }

        [Fact]
        public void TestNot()
        {
            Assert.True(false.Not());
            Assert.False(true.Not());
        }
    }
}
