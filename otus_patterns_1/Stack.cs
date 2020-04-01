using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace otus_patterns_1
{
    public class Stack
    {
        private readonly List<string> _stack;
        public Stack()
        {
            _stack = new List<string>();
        }
        public void Push(string data)
        {
            _stack.Add(data);
        }
        public void Pop(string data)
        {
            _stack.Remove(data);
        }
        public string GetLast()
        {
            return _stack.Last();
        }
        public bool IsEmpty()
        {
            return _stack.Count == 0;
        }
        public List<string> Get()
        {
            return _stack;
        }
    }
}
