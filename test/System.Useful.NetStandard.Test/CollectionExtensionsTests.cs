using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace System.Useful.NetStandard.Test
{
    public class CollectionExtensionsTests
    {
        [Fact]
        public void TestAddorUpdate()
        {
            Dictionary<int, int> x = new Dictionary<int, int>();
            Assert.False(x.ContainsKey(10));

            x.AddOrUpdate(10, 20);
            Assert.True(x.ContainsKey(10));
            Assert.Equal(20, x[10]);

            x.AddOrUpdate(10, 30);
            Assert.True(x.ContainsKey(10));
            Assert.Equal(30, x[10]);
        }

        [Fact]
        public void TestAddOrConcat()
        {
            Dictionary<int, List<int>> x = new Dictionary<int, List<int>>();
            Assert.False(x.ContainsKey(10));

            x.AddOrConcat(10, 20);
            Assert.True(x.ContainsKey(10));
            Assert.Single(x[10]);

            x.AddOrConcat(10, 30);
            Assert.True(x.ContainsKey(10));
            Assert.Equal(2, x[10].Count);

            x.AddOrUpdate(10, new List<int> { 1, 2, 3 });
            Assert.True(x.ContainsKey(10));
            Assert.Equal(3, x[10].Count);
        }

        [Fact]
        public void TestGetValueOrDefault()
        {
            Dictionary<int, int> x = new Dictionary<int, int> { { 1, 2 }, { 3, 4 } };
            Assert.Equal(2, x.GetValueOrDefault(1));
            Assert.Equal(0, x.GetValueOrDefault(10));
        }

        [Fact]
        public void TestGetAtIndexOrDefault()
        {
            List<int> x = new List<int> { 1, 2, 3 };
            Assert.Equal(2, x.GetAtIndexOrDefault(1));
            Assert.Equal(0, x.GetAtIndexOrDefault(10));
        }

        [Fact]
        public void TestGetValueOrNull()
        {
            Dictionary<int, int> x = new Dictionary<int, int> { { 1, 2 }, { 3, 4 } };
            Assert.Equal(2, x.GetValueOrNull(1));
            Assert.Null(x.GetValueOrNull(10));
        }

        [Fact]
        public void TestGetAtIndexOrNull()
        {
            List<int> x = new List<int> { 1, 2, 3 };
            Assert.Equal(2, x.GetAtIndexOrNull(1));
            Assert.Null(x.GetAtIndexOrNull(10));
        }

        [Fact]
        public void TestIsNotNullAndEmpty()
        {
            List<int> l1 = null;
            List<int> l2 = new List<int>();
            List<int> l3 = new List<int> { 1, 2, 3 };

            Assert.False(List.IsNotNullAndEmpty(l1));
            Assert.False(List.IsNotNullAndEmpty(l2));
            Assert.True(List.IsNotNullAndEmpty(l3));

            Assert.False(l1.IsNotNullAndEmpty());
            Assert.False(l2.IsNotNullAndEmpty());
            Assert.True(l3.IsNotNullAndEmpty());
        }

         [Fact]
        public void TestIsNullOrEmpty()
        {
            List<int> l1 = null;
            List<int> l2 = new List<int>();
            List<int> l3 = new List<int> { 1, 2, 3 };

            Assert.True(List.IsNullOrEmpty(l1));
            Assert.True(List.IsNullOrEmpty(l2));
            Assert.False(List.IsNullOrEmpty(l3));

            Assert.True(l1.IsNullOrEmpty());
            Assert.True(l2.IsNullOrEmpty());
            Assert.False(l3.IsNullOrEmpty());
        }

        [Fact]
        public void TestPyListAndIndexer()
        {
            PyList<int> x = new List<int> { 1, 2, 3, 4, 5, 6 };

            Assert.Equal(1, x["0"].First());
            Assert.Equal(x["-1"].First(), x["5"].First());

            Assert.Equal(2, x["1:"].First());
            Assert.Equal(6, x["1:"].Last());

            Assert.Equal(1, x[":"].First());
            Assert.Equal(6, x[":"].Last());

            Assert.Equal(1, x[":2"].First());
            Assert.Equal(3, x[":2"].Last());

            Assert.Equal(6, x["-1:0"].First());
            Assert.Equal(1, x["-1:0"].Last());

            Assert.Equal(1, x["0:-1"].First());
            Assert.Equal(6, x["0:-1"].Last());

            Assert.Equal(5, x["-2:-1"].First());
            Assert.Equal(6, x["-2:-1"].Last());



            Assert.Equal(2, x["1::"].First());
            Assert.Equal(6, x["1::"].Last());

            Assert.Equal(1, x["::"].First());
            Assert.Equal(6, x["::"].Last());

            Assert.Equal(1, x[":2:"].First());
            Assert.Equal(3, x[":2:"].Last());

            Assert.Equal(6, x["-1:0:"].First());
            Assert.Equal(1, x["-1:0:"].Last());

            Assert.Equal(1, x["0:-1:"].First());
            Assert.Equal(6, x["0:-1:"].Last());

            Assert.Equal(5, x["-2:-1:"].First());
            Assert.Equal(6, x["-2:-1:"].Last());


            Assert.Equal(2, x["1::1"].First());
            Assert.Equal(6, x["1::1"].Last());

            Assert.Equal(6, x["::-1"].First());
            Assert.Equal(1, x["::-1"].Last());

            Assert.Equal(6, x["::-3"].First());
            Assert.Equal(3, x["::-3"].Last());

            Assert.Equal(6, x["-1:0:2"].First());
            Assert.Equal(2, x["-1:0:2"].Last());

            Assert.Equal(6, x["0:-1:-1"].First());
            Assert.Equal(1, x["0:-1:-1"].Last());

            Assert.Equal(5, x["-2:-1:9"].First());
            Assert.Equal(5, x["-2:-1:9"].Last());

            Assert.Equal(1, x[0]);
            Assert.Equal(x[-1], x[5]);
        }

        [Fact]
        public void TestPyListAndIndexerEx()
        {
            PyList<int> x = new List<int> { 1, 2, 3 };

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var temp1 = x[-56];
            });
        }
    }
}