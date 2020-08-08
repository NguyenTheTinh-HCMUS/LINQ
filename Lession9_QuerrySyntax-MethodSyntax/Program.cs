using System;
using System.Linq;

namespace Lession9_QuerrySyntax_MethodSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            // querry syntax
            int[] numbers = { 2,5,28,31,17,16,42};
            var numsQuery = from n in numbers
                            where n < 20
                            select n;
            foreach(var i in numsQuery)
            {
                Console.WriteLine(i);
            }
            // methos syntax uses standard method invocations
                // use extention method
                // convert at complier
                // it is called as fluent syntax bc it allows series
                    // of extension method call.
            var numsMethod = numbers.Where(x => x < 20);

            foreach (var i in numsMethod)
            {
                Console.WriteLine(i);
            }

            // The standard query operators: comprise  a set of method
                // called an application programming interface(API) that
                // lets you query any .NET array or collection
                // Some oprater return IEnumable Object(or other sequences)
                 // while others return scalars



        }
    }
}
