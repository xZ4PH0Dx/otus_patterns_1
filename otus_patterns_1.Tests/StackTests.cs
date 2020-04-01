using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace otus_patterns_1.Tests
{
    public class StackTests
    {
        [Fact]
        public void Get()
        {
            var stack = new Stack();
            stack.Push("test");
            stack.Push("test2");
            var testList = new List<string>
            {
                "test",
                "test2"
            };
            Assert.Equal(testList, stack.Get());
        }
        [Fact]
        public void GetLast()
        {
            var stack = new Stack();
            stack.Push("test");
            stack.Push("test2");
            Assert.Equal("test2", stack.GetLast());
        }
        [Fact]
        public void Push()
        {
            var stack = new Stack();
            stack.Push("test");
            var testList = new List<string>
            {
                "test",
            };
            Assert.Equal(testList, stack.Get());
        }
        [Fact]
        public void Pop()
        {
            var stack = new Stack();
            stack.Push("test");
            stack.Pop("test");
            Assert.True(stack.IsEmpty());
        }
        [Fact]
        public void IsEmpty()
        {
            var stack = new Stack();
            Assert.True(stack.IsEmpty());
        }
    }
}
