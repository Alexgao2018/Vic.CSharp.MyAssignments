using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_AlexGao_proj
{
    class Teacher : Person
    {
        private string name;
        private string faculty;
        private int officeTel;
        private string course;

        public string Name { get; set; }
        public string Faculty { get; set; }
        public int  OfficeTel { get; set; }
        public string[] Courses;

        public static void StaticMethod()
        {
            Console.WriteLine("++Teacher: Static Method Invoke---");
        }

        public void Teacher_Method_1() {
            Console.WriteLine("Teacher_method_1() is invoked");
        }

        //public string[] OpenCourse() { return ["C#", "Python", "SQL"]; }
        //public string[] CloseCourse() { return ["C#","Python"]; }
        public bool UploadScores() { return true; }        

        public override string ToString()
        {
            return "Teacher Name: " + this.name + ", Faculty: " + this.faculty + "----";
        }
    }
}
