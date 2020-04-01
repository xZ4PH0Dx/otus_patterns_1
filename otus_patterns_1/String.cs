using System;

namespace otus_patterns_1
{
    public class String
    {
        private string _data = "";
        private int _length;
        public String()
        {
        }
        public String(string word)
        {
            _data = word;
            _length = _data.Length;
        }
        public String(char symbol)
        {
            _data = symbol.ToString();
            _length = _data.Length;
        }
        public int GetLength()
        {
            return _length;
        }
        public string GetString()
        {
            return _data;
        }
        public void Reset()
        {
            _data = "";
            _length = 0;
        }
        ~String()
        {
            Console.WriteLine("Объект уничтожен");
        }
    }
}
