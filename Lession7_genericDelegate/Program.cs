using System;

namespace Lession7_genericDelegate
{
    class Program
    {
        public static float TrianglePerimeter(float a,float b,float c)
        {
            return a + b + c;
        }
        static void Main(string[] args)
        {
            // using Func
            Func<int,int,int> delegateAdd=(a,b)=>a + b;
            Func<int, int, int> delegateMutiple = delegate (int a, int b)
                {
                    return a + b;
                };
            Func<float, float, float, float> Tperimeter = TrianglePerimeter;
        }
    }
}
