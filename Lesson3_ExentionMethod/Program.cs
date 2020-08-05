using System;

namespace Lesson3_ExentionMethod

{
    static class Mystring
    {
        public static int WordCount(this string str)
        {
            string[] strArray = str.Split(' ');
            return strArray.Length;

        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            string str = "Hello World";
            int a= str.WordCount();
            Console.WriteLine(a);
        }
    }
}
