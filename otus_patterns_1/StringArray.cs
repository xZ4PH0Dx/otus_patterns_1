using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace otus_patterns_1
{
    public class StringArray : String
    {
        public StringArray()
            : base()
        {
        }
        public StringArray(string word)
            : base(word)
        {
        }
        public StringArray(char symbol)
            : base(symbol)
        {
        }
        public char[] GetArray(int start = 0, int limit = 0)
        {
            if (GetLength() == 0) return new char[]{};

            if (start == 0) return GetString().ToCharArray();

            return limit != 0 ? GetString().Skip(start).Take(limit).ToArray() 
                : GetString().ToCharArray().Skip(start).ToArray();
        }
    }
}
