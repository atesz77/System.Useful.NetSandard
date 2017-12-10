using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace System.Useful.NetStandard.Test
{
    public class CommonExtensionsTests
    {
        [Fact]
        public void TestTry()
        {
            List<int> testList = null;
            var val = T.ry(testList, x => x[2]);

            Assert.Equal(0, val);
        }

        [Fact]
        public void TestTryDefault()
        {
            List<int> testList = null;
            var val = T.ry(testList, x => x[2], 10);

            Assert.Equal(10, val);
        }

        [Fact]
        public void TestArrayString()
        {
            var coll = Ar.ray("test1", "test2", "test3");
            Assert.IsType<string[]>(coll);
            Assert.Equal(3, coll.Length);
            Assert.Equal("test2", coll[1]);
        }

        [Fact]
        public void TestArrayInt()
        {
            var coll = Ar.ray(1, 2, 3, 4);
            Assert.IsType<string[]>(coll);
            Assert.Equal(4, coll.Length);
            Assert.Equal("2", coll[1]);
        }

        [Fact]
        public void TestListString()
        {
            var coll = Li.st("test1", "test2", "test3");
            Assert.IsType<List<string>>(coll);
            Assert.Equal(3, coll.Count);
            Assert.Equal("test2", coll[1]);
        }

        [Fact]
        public void TestListInt()
        {
            var coll = Li.st(1, 2, 3, 4);
            Assert.IsType<List<string>>(coll);
            Assert.Equal(4, coll.Count);
            Assert.Equal("2", coll[1]);
        }
    }
}
