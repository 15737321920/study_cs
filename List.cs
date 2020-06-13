using System;
using System.Collections.Generic;
using System.Linq;

namespace List
{
    class Program
    {
        static void Main(String[] args)
        {
            String[] MyString = { "a","b","c" };
            List<String> MyStringList = new List<String>(MyString);
            Console.WriteLine("Original list", MyString);
            //1.Push: Add one element Stringo the stack.
            MyString.Append("d");
            Console.WriteLine("Added one element Stringo the original list", MyString);
            //2.Pop: Remove the last added element and return it
            int i = MyString.Count() - 1;
            List<String> MyStringListReverse = new List<String>();
            //3.Peek: Return the last added element without remove it.
            string LastString = MyStringListReverse.First();
            MyStringListReverse.RemoveAt(0);
            Console.WriteLine("Removed the last added element", LastString);
        }
    }
}
