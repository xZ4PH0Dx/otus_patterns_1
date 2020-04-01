using System;

namespace otus_patterns_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var string1 = new StringArray();
            Console.WriteLine($"Empty length: {string1.GetLength()}");
            Console.WriteLine($"Empty string: {string1.GetString()}");

            var string2 = new StringArray('a');
            Console.WriteLine($"Char length: {string2.GetLength()}");
            Console.WriteLine($"Char string: {string2.GetString()}");

            var string3 = new StringArray("test");
            Console.WriteLine($"String length: {string3.GetLength()}");
            Console.WriteLine($"String string: {string3.GetString()}");

            var stringArray = new StringArray("test2");
            Console.WriteLine(stringArray.GetArray());
            Console.WriteLine(stringArray.GetArray(3, 2));

            var stack = new Stack();
            stack.Push(string3.GetString());
            stack.Push(stringArray.GetString());

            Console.WriteLine("Stack all:");

            stack.Get().ForEach(Console.WriteLine);

            Console.WriteLine($"Stack top: {stack.GetLast()}");
            Console.WriteLine($"Stack isEmpty: {stack.IsEmpty()}");

            stack.Pop(string3.GetString());

            Console.WriteLine("Stack all after delete:");
            stack.Get().ForEach(Console.WriteLine);

            string3.Reset();

            Console.WriteLine($"Reset length: {string3.GetLength()}");
            Console.WriteLine($"Reset string: {string3.GetString()}");
        }
    }
}
    