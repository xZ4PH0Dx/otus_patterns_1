using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace otus_patterns_1.Tests
{
    public class StringTests
    {
        [Fact]
        public void GetLength()
        {
            var string1 = new String("test");
            var string1Length = string1.GetLength();
            Assert.Equal(4, string1Length);
        }
        [Fact]
        public void GetString()
        {
            var string1 = new String("test");
            Assert.Equal("test", string1.GetString());
        }
        [Fact]
        public void Reset()
        {
            var string1 = new String("test");
            string1.Reset();
            Assert.Equal("", string1.GetString());
        }
    }
}
