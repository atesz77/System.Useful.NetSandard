using System;
using Xunit;

namespace System.Useful.NetStandard.Test
{
    public enum TestEnum
    {
        Test1,
        Test2,
        Test3
    }

    public class CastExtensionsTests
    {
        [Fact]
        public void TestCastInt2Enum()
        {
            TestEnum x = TestEnum.Test2;
            Assert.Equal(1, x.I());
        }

        [Fact]
        public void TestCastEnum2Int()
        {
            int x = 2;
            Assert.Equal(TestEnum.Test3, x.E<TestEnum>());
        }
    }
}
