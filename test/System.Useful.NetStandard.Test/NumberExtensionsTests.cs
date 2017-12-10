using System;
using System.Linq;
using Xunit;

namespace System.Useful.NetStandard.Test
{
    public class NumberExtensionsTests
    {
        [Fact]
        public void TestRandom1()
        {
            int r1 = 123456.Random(4234);
            int r2 = 123456.Random(22);
            Assert.NotEqual(r1, r2);
        }

        [Fact]
        public void TestRandom2()
        {
            int r1 = 123456.Random(10);
            int r2 = 123456.Random(10);
            Assert.Equal(r1, r2);
        }

        [Fact]
        public void TestRandom3()
        {
            byte[] bytes = new byte[10];
            Assert.Equal(0, bytes.First());
            Assert.Equal(0, bytes.Last());
            bytes.Random();
            Assert.NotEqual(0, bytes.First());
            Assert.NotEqual(0, bytes.Last());
        }

        [Fact]
        public void TestTimes1()
        {
            int x = 0;
            10.Times(() => x += 2);
            Assert.Equal(20, x);
        }

        [Fact]
        public void TestTimes2()
        {
            int x = 0;
            10.Times((i) => x = i);
            Assert.Equal(9, x);
        }

        [Fact]
        public void TestBetween()
        {
            Assert.True(10.Between(1, 20));
            Assert.False(10.Between(30, 40));
        }
    }
}
