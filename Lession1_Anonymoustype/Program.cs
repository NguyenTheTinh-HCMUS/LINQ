using System;
using System.Linq;

namespace Lession1_Anonymoustype
{
    class Program
    {

        static void Main(string[] args)
        {
            // create a anonymous type  with use var keyword
            var test = new { a = "Nguyen Van A" };
            //test.a = "sjjss"; ===> error bc it only used to be read and ot change value
        }
    }
}
