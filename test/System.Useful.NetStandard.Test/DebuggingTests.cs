using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace System.Useful.NetStandard.Test
{
	class TestValue
    {
        public int I { get; set; }
        public string S { get; set; }

        public static List<TestValue> GetTestValues()
        {
            List<TestValue> x = new List<TestValue>
            {
                new TestValue
                {
                    I = 1,
                    S = "kutya"
                },
                new TestValue
                {
                    I = 2,
                    S = "kutya"
                },
                new TestValue
                {
                    I = 3,
                    S = "cica"
                },
                new TestValue
                {
                    I = 1,
                    S = "kutya"
                },
                new TestValue
                {
                    I = 1,
                    S = "cica"
                }
            };

            return x;
        }

        public static List<int> GetTestValues2()
        {
            List<int> x = new List<int>
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 2, 3
            };

            return x;
        }
    }

    public class DebuggingTests
    {
    	[Fact]
        public void TestWhereWithProperty()
        {
            var x = TestValue.GetTestValues();

            var res1 = Debugging.Where(x, "I", 3);
            var res2 = Debugging.Where(x, "I", 1);
            var res3 = Debugging.Where(x, "S", "kutya");

            Assert.Single(res1);
            Assert.Equal(3, res2.Count());
            Assert.Equal(3, res3.Count());

            var res1X = x.WhereDebug("I", 3);
            var res2X = x.WhereDebug("I", 1);
            var res3X = x.WhereDebug("S", "kutya");

            Assert.Single(res1X);
            Assert.Equal(3, res2X.Count());
            Assert.Equal(3, res3X.Count());
        }

        [Fact]
        public void TestWhereComparer()
        {
            var x = TestValue.GetTestValues2();

            var res1 = Debugging.Where(x, '=', 3);
            var res2 = Debugging.Where(x, '<', 5);
            var res3 = Debugging.Where(x, '>', 5);
            var res4 = Debugging.Where(x, '!', 3);
            try
            {
                Debugging.Where(x, 'a', 3).Count();
                Assert.True(false);
            }
            catch (InvalidOperationException e)
            {
                if (e.Message == "Not supported comparer")
                {
                    Assert.True(true);
                }
                else
                {
                    Assert.True(false);
                }
            }

            Assert.Equal(3, res1.Count());
            Assert.Equal(10, res2.Count());
            Assert.Equal(4, res3.Count());
            Assert.Equal(12, res4.Count());
            try
            {
                x.WhereDebug('a', 3).Count();
                Assert.True(false);
            }
            catch (InvalidOperationException e)
            {
                if (e.Message == "Not supported comparer")
                {
                    Assert.True(true);
                }
                else
                {
                    Assert.True(false);
                }
            }

            var res1X = x.WhereDebug('=', 3);
            var res2X = x.WhereDebug('<', 5);
            var res3X = x.WhereDebug('>', 5);
            var res4X = x.WhereDebug('!', 3);

            Assert.Equal(3, res1X.Count());
            Assert.Equal(10, res2X.Count());
            Assert.Equal(4, res3X.Count());
            Assert.Equal(12, res4X.Count());
        }

        [Fact]
        public void TestSelect()
        {
            var x = TestValue.GetTestValues();

            var res1 = Debugging.Select(x, "I");
            var res2 = Debugging.Select(x, "S");

            Assert.Equal(5, res1.Count());
            Assert.Equal(5, res2.Count());

            var res1X = x.SelectDebug("I");
            var res2X = x.SelectDebug("S");

            Assert.Equal(5, res1X.Count());
            Assert.Equal(5, res2X.Count());
        }
    }
}