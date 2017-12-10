using System;
using Xunit;

namespace System.Useful.NetStandard.Test
{
    public class StringExtensionsTests
    {
        [Fact]
        public void TestStringEx()
        {
            StringEx x = "cicamica";
            string s = "cicamica";

            Assert.Equal(x, s);

            string s1 = "cicaxica";
            x[4] = 'x';

            Assert.Equal(x, s1);
        }

        [Fact]
        public void TestIs()
        {
            var guidstr = Guid.NewGuid().ToString();
            Assert.True("123".IsNumber());
            Assert.False("asd".IsNumber());

            Assert.True(guidstr.IsGuid());
            Assert.False("asd".IsNumber());
        }

        [Fact]
        public void TestIsNullOrEmpty()
        {
            string s1 = null;
            string s2 = "";
            string s3 = "x";

            Assert.Equal(string.IsNullOrEmpty(s1), s1.IsNullOrEmpty());
            Assert.Equal(string.IsNullOrEmpty(s2), s2.IsNullOrEmpty());
            Assert.Equal(string.IsNullOrEmpty(s3), s3.IsNullOrEmpty());
        }

        [Fact]
        public void TestIsNullOrWhiteSpace()
        {
            string s1 = null;
            string s2 = " ";
            string s3 = "x";
            string s4 = "";

            Assert.Equal(string.IsNullOrWhiteSpace(s1), s1.IsNullOrWhiteSpace());
            Assert.Equal(string.IsNullOrWhiteSpace(s2), s2.IsNullOrWhiteSpace());
            Assert.Equal(string.IsNullOrWhiteSpace(s3), s3.IsNullOrWhiteSpace());
            Assert.Equal(string.IsNullOrWhiteSpace(s4), s4.IsNullOrWhiteSpace());
        }

        //[Fact]
        //public void TestIsNullOrEmptyOrWhiteSpace()
        //{
        //    string s1 = null;
        //    string s2 = "";
        //    string s3 = " ";
        //    string s4 = "x";

        //    Assert.Equal(string.IsNullOrEmpty(s1) || string.IsNullOrWhiteSpace(s1), s1.IsNullOrEmptyOrWhiteSpace());
        //    Assert.Equal(string.IsNullOrEmpty(s2) || string.IsNullOrWhiteSpace(s2), s2.IsNullOrEmptyOrWhiteSpace());
        //    Assert.Equal(string.IsNullOrEmpty(s3) || string.IsNullOrWhiteSpace(s3), s3.IsNullOrEmptyOrWhiteSpace());
        //    Assert.Equal(string.IsNullOrEmpty(s4) || string.IsNullOrWhiteSpace(s4), s4.IsNullOrEmptyOrWhiteSpace());
        //}

        [Fact]
        public void TestFormat()
        {
            Assert.Equal("1sda", "{0}sd{1}".Format(1, "a"));
        }

        [Fact]
        public void TestJoin()
        {
            Assert.Equal("1,2,3", new[] { 1, 2, 3 }.Join(","));
        }

        [Fact]
        public void TestSplit()
        {
            string x = "a,,b---c;;d";
            var splitX = x.Split(",,", "---", ";;");

            Assert.Equal("a", splitX[0]);
            Assert.Equal("b", splitX[1]);
            Assert.Equal("c", splitX[2]);
            Assert.Equal("d", splitX[3]);
        }

        [Fact]
        public void TestSplitIgnore()
        {
            string x = ",b(c,d,e,);g,h";
            string y = "a,b,(c;d(e,f),g,f);x,y";

            var splitX = x.SplitIgnore('(', ')', ',', ';');
            var splitY = y.SplitIgnore('(', ')', ',', ';');

            Assert.Equal(4, splitX.Length);
            Assert.Equal(5, splitY.Length);


            Assert.Equal("", splitX[0]);
            Assert.Equal("b(c,d,e,)", splitX[1]);
            Assert.Equal("g", splitX[2]);
            Assert.Equal("h", splitX[3]);

            Assert.Equal("a", splitY[0]);
            Assert.Equal("b", splitY[1]);
            Assert.Equal("(c;d(e,f),g,f)", splitY[2]);
            Assert.Equal("x", splitY[3]);
            Assert.Equal("y", splitY[4]);
        }
    }
}