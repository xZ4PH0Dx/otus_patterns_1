using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace otus_patterns_1.Tests
{
    public class StringArrayTests
    {
        [Fact]
        public void GetArray()
        {
            var string1 = new StringArray("test");
            var string1Array = string1.GetArray(2, 2);
            Assert.Equal(new[] { 's', 't' }, string1Array);
        }
    }
}
