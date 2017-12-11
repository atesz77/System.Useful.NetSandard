using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace System.Useful.NetStandard.Test
{
    public class TupleExtensionsTests
    {
    	[Fact]
        public void TestEmpty()
        {
            tuple<int, int, string> t = new tuple<int, int, string>();
            Assert.Equal(0, t.Item1);
            Assert.Equal(0, t.Item2);
            Assert.Null(t.Item3);
        }

        [Fact]
        public void TestModify()
        {
            tuple<int, int, string> t = new tuple<int, int, string>(1, 2, "dog");
            t.Item3 = "chow";

            Assert.Equal(1, t.Item1);
            Assert.Equal(2, t.Item2);
            Assert.Equal("chow", t.Item3);
        }

        [Fact]
        public void TestModify2()
        {
             (int, int, string) tnet = (1, 2, "dog");
            tuple<int, int, string> t = tnet;

            Assert.Equal(1, t.Item1);
            Assert.Equal(2, t.Item2);
            Assert.Equal("dog", t.Item3);

            t.Item3 = "chow";

            Assert.Equal(1, t.Item1);
            Assert.Equal(2, t.Item2);
            Assert.Equal("chow", t.Item3);
        }

        [Fact]
        public void TestToTuple()
        {
            tuple<int, int, string> t = new tuple<int, int, string>(1, 2, "dog");
            t.Item3 = "chow";
            (int, int, string) tnet = t;

            Assert.Equal(1, t.Item1);
            Assert.Equal(2, t.Item2);
            Assert.Equal("chow", t.Item3);
        }

        [Fact]
        public void TestTotuple()
        {
            (int, int, string) tnet = (1, 2, "dog");
            tuple<int, int, string> t = tnet;

            Assert.Equal(1, t.Item1);
            Assert.Equal(2, t.Item2);
            Assert.Equal("dog", t.Item3);
        }
    }
}