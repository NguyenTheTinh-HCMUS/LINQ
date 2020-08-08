using System;
using System.Collections.Generic;
using System.Linq;
namespace Lesion15_SelectManyOperator
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

            // using syxtax querry

            ////IEnumerable<string> mystud = from s in allStud
            ////             from sb in s.Subjects
            ////             select sb;



            ////foreach (string s in mystud)
            ////{
            ////    Console.WriteLine(s);

            ////}

            // using method querry


            IEnumerable<string> mystud = allStud.SelectMany(s=>s.Subjects);



            foreach (string s in mystud)
            {
                Console.WriteLine(s);

            }




        }
    }
}

