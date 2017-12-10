using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace System.Useful.NetStandard.Test
{
    public class LinqExtensionsTests
    {
    	[Fact]
        public void TestSelectL()
        {
            List<int> l = new List<int> { 1, 2, 3 };
            Assert.IsType<List<int>>(l.SelectL(x => x));
        }

        [Fact]
        public void TestSelectA()
        {
            int[] l = new[] { 1, 2, 3 };
            Assert.IsType<int[]>(l.SelectA(x => x));
        }

        [Fact]
        public void TestWhereSelectL()
        {
            List<int> l = new List<int> { 1, 2, 3, 4, 5 };
            Assert.IsType<List<int>>(l.WhereSelectL(x => x % 2 == 0, y => y));
            Assert.Equal(2, l.WhereSelectL(x => x % 2 == 0, y => y).Count);
        }

        [Fact]
        public void TestWhereSelectA()
        {
            int[] l = new[] { 1, 2, 3, 4, 5 };
            Assert.IsType<int[]>(l.WhereSelectA(x => x % 2 == 1, y => y));
            Assert.Equal(3, l.WhereSelectA(x => x % 2 == 1, y => y).Length);
        }

        [Fact]
        public void TestSublist()
        {
            List<int> x = new List<int> { 1, 2, 3, 4, 5 };
            var subX = x.Sublist(1, 3);
            Assert.Equal(2, subX.First());
            Assert.Equal(4, subX.Last());
        }

        [Fact]
        public void TestSplice()
        {
            List<int> x = new List<int> { 1, 2, 3, 4, 5 };
            var subX = x.Splice(0, 3);
            Assert.Equal(1, subX.First());
            Assert.Equal(3, subX.Last());
        }
    }
}