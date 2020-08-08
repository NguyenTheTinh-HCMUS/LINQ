using System;

namespace Lession6_LamdaExpression
{
    class Program
    {
        public delegate float PointerToFunc(float val);
        static void Main(string[] args)
        {
            PointerToFunc arae = a => a * 3.14F;
            Console.WriteLine(arae(10));
        }
    }
}
