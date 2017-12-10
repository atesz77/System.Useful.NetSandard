using System;
using Xunit;

namespace System.Useful.NetStandard.Test
{
    public class ParseExtensionsTests
    {
        [Fact]
        public void TestParseGuid()
        {
            var guidstr = Guid.NewGuid().ToString();
            guidstr.ParseGuid();
        }

        [Fact]
        public void TestParseGuidEx()
        {
            Assert.Throws<FormatException>(() =>
            {
                "asd".ParseGuid();
            });
        }

        [Fact]
        public void TestTryParseGuid()
        {
            var guidstr = Guid.NewGuid().ToString();
            Assert.NotNull(guidstr.TryParseGuid());
            Assert.Null("asd".TryParseGuid());
        }

        [Fact]
        public void TestParseBool()
        {
            Assert.True("true".ParseBool());
            Assert.False("false".ParseBool());
        }

        [Fact]
        public void TestParseBoolEx()
        {
            Assert.Throws<FormatException>(() =>
            {
                "asd".ParseBool();
            });
        }

        [Fact]
        public void TestTryParseBool()
        {
            Assert.True("true".TryParseBool());
            Assert.False("false".TryParseBool());
            Assert.Null("asd".TryParseBool());
        }


        [Fact]
        public void TestParseChar()
        {
            Assert.Equal('x', "x".ParseChar());
        }

        [Fact]
        public void TestParseCharEx()
        {
            Assert.Throws<FormatException>(() =>
            {
                "asd".ParseChar();
            });
        }

        [Fact]
        public void TestTryParseChar()
        {
            Assert.Equal('x', "x".TryParseChar());
            Assert.Null("asd".TryParseByte());
        }


        [Fact]
        public void TestParseByte()
        {
            Assert.Equal(3, "3".ParseByte());
        }

        [Fact]
        public void TestParseByteEx()
        {
            Assert.Throws<FormatException>(() =>
            {
                "asd".ParseByte();
            });
        }

        [Fact]
        public void TestTryParseByte()
        {
            Assert.Equal(3.B(), "3".TryParseByte());
            Assert.Null("asd".TryParseByte());
        }


        [Fact]
        public void TestParseSByte()
        {
            Assert.Equal(3, "3".ParseSByte());
        }

        [Fact]
        public void TestParseSByteEx()
        {
            Assert.Throws<FormatException>(() =>
            {
                "asd".ParseSByte();
            });
        }

        [Fact]
        public void TestTryParseSByte()
        {
            Assert.Equal(3.SB(), "3".TryParseSByte());
            Assert.Null("asd".TryParseSByte());
        }

        [Fact]
        public void TestParseShort()
        {
            Assert.Equal(3, "3".ParseShort());
        }

        [Fact]
        public void TestParseShortEx()
        {
            Assert.Throws<FormatException>(() =>
            {
                "asd".ParseShort();
            });
        }

        [Fact]
        public void TestTryParseShort()
        {
            Assert.Equal(3.S(), "3".TryParseShort());
            Assert.Null("asd".TryParseShort());
        }

        [Fact]
        public void TestParseUShort()
        {
            Assert.Equal(3, "3".ParseUShort());
        }

        [Fact]
        public void TestParseUShortEx()
        {
            Assert.Throws<FormatException>(() =>
            {
                "asd".ParseUShort();
            });
        }

        [Fact]
        public void TestTryParseUShort()
        {
            Assert.Equal(3.US(), "3".TryParseUShort());
            Assert.Null("asd".TryParseUShort());
        }

        [Fact]
        public void TestParseInt()
        {
            Assert.Equal(3, "3".ParseInt());
        }

        [Fact]
        public void TestParseIntEx()
        {
            Assert.Throws<FormatException>(() =>
            {
                "asd".ParseInt();
            });
        }

        [Fact]
        public void TestTryParseInt()
        {
            Assert.Equal(3, "3".TryParseInt());
            Assert.Null("asd".TryParseInt());
        }

        [Fact]
        public void TestParseUInt()
        {
            Assert.Equal(3.UI(), "3".ParseUInt());
        }

        [Fact]
        public void TestParseUIntEx()
        {
            Assert.Throws<FormatException>(() =>
            {
                "asd".ParseUInt();
            });
        }

        [Fact]
        public void TestTryParseUInt()
        {
            Assert.Equal(3.UI(), "3".TryParseUInt());
            Assert.Null("asd".TryParseUInt());
        }

        [Fact]
        public void TestParseLong()
        {
            Assert.Equal(3, "3".ParseLong());
        }

        [Fact]
        public void TestParseLongEx()
        {
            Assert.Throws<FormatException>(() =>
            {
                "asd".ParseLong();
            });
        }

        [Fact]
        public void TestTryParseLong()
        {
            Assert.Equal(3, "3".TryParseLong());
            Assert.Null("asd".TryParseLong());
        }

        [Fact]
        public void TestParseULong()
        {
            Assert.Equal(3.UL(), "3".ParseULong());
        }

        [Fact]
        public void TestParseULongEx()
        {
            Assert.Throws<FormatException>(() =>
            {
                "asd".ParseULong();
            });
        }

        [Fact]
        public void TestTryParseULong()
        {
            Assert.Equal(3.UL(), "3".TryParseULong());
            Assert.Null("asd".TryParseULong());
        }


        [Fact]
        public void TestParseFloat()
        {
            try
            {
                Assert.Equal(3.5, "3.5".ParseFloat());
            }
            catch
            {
                Assert.Equal(3.5, "3,5".ParseFloat());
            }
        }

        [Fact]
        public void TestParseFloatEx()
        {
            Assert.Throws<FormatException>(() =>
            {
                "asd".ParseFloat();
            });
        }

        [Fact]
        public void TestTryParseFloat()
        {
            try
            {
                Assert.Equal(3.5f, "3.5".TryParseFloat());
            }
            catch
            {
                Assert.Equal(3.5f, "3,5".TryParseFloat());
            }
            Assert.Null("asd".TryParseFloat());
        }

        [Fact]
        public void TestParseFloatInvariant()
        {
            Assert.Equal(3.5, "3.5".ParseFloatInvariant());
            Assert.Equal(3.5, "3,5".ParseFloatInvariant());
        }

        [Fact]
        public void TestParseFloatInvariantEx()
        {
            Assert.Throws<FormatException>(() =>
            {
                "asd".ParseFloatInvariant();
            });
        }

        [Fact]
        public void TestTryParseFloatInvariant()
        {
            Assert.Equal(3.5f, "3.5".TryParseFloatInvariant());
            Assert.Equal(3.5f, "3,5".TryParseFloatInvariant());
            Assert.Null("asd".TryParseFloatInvariant());
        }
    }
}
