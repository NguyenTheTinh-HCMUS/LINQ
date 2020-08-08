using System;

namespace Lession5_anonymousMethod
{
    class Program
    {
        public delegate float PointerToFun(float val);

        static void Main(string[] args)
        {
            PointerToFun circleArea = delegate (float r)
            {
                return 3.14F * r;
            };
            Console.WriteLine(circleArea(3));
        }
    }
}
