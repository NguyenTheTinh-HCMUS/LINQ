using System;
using System.Collections.Generic;
using System.Linq;
namespace Lession16_Partitioning
{
    class Program
    {
        class Student
        {
            public int Rollno { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Area { get; set; }
            public string[] Subjects { get; set; }
            public static IList<Student> GetAll()
            {
                List<Student> lst = new List<Student>()
                {
                    new Student{
                        Rollno=89,Name="Pryial",Age=15,Area="Agra",Subjects=new string[]{"C","C++","DS"}
                    },
                     new Student{
                        Rollno=23,Name="Amit",Age=12,Area="Mumbai",Subjects=new string[]{"PHP","JSP"}
                    },
                      new Student{
                        Rollno=10,Name="Ramesh",Age=15,Area="Pune",Subjects=new string[]{"C#","VB","MVC"}
                    },
                      new Student{
                        Rollno=5,Name="Reema",Age=12,Area="Agra",Subjects=new string[]{"DAA","CG"}
                    },
                      new Student{
                        Rollno=30,Name="Ajit",Age=17,Area="Mumbai",Subjects=new string[]{"Maths","Physis"}
                    }


                };

                return lst;

            }
            public override string ToString()
            {
                return $"{Rollno,5}{Name,5}{Age,5}{Area,5}";
            }
        }
        static void Main(string[] args)
        {
            // all student details
            IList<Student> allStud = Student.GetAll();




            IEnumerable<Student> last1 = allStud.Take(3);

            Console.WriteLine("Take fist 3 records\n");

            foreach (Student s in last1)
            {
                Console.WriteLine(s);

            }
            IEnumerable<Student> last2 = allStud.Skip(3);
            Console.WriteLine("\nSkip fist 3 records\n");

            foreach(Student s in last2)
            {
                Console.WriteLine(s);

            }







        }
    }
}
