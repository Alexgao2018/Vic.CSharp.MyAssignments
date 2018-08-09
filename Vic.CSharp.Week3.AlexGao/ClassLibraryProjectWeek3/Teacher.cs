using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProjectWeek3
{
    //class Teacher
    //{
    //}
    class Teacher : Person
    { 
        public string Name { get; set; }
        public string Faculty { get; set; }
        public int OfficeTel { get; set; }
        public string[] Courses;

        public static void StaticMethod()
        {
            Console.WriteLine("++Teacher: Static Method Invoke---");
        }

        public void Teacher_Method_1()
        {
            Console.WriteLine("Teacher_method_1() is invoked");
        }

        
        public bool UploadScores() { return true; }

        public override string ToString()
        {
            return ("Teacher Name:{0} Faculty:{1} ----", Name, Faculty);
        }
    }
}
