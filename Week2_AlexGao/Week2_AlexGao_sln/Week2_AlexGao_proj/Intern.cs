using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_AlexGao_proj
{
    class Intern : Student
    {
        private string name;
        private int age;
        private string major;
        private string company;

        public string Name { get; set; }
        public int Age { get; set; }
        public string Major { get; set; }
        public string Company { get; set; }

        public void Intern_Method_1() {
            Console.WriteLine("Intern_method_1() is invoked");
        }

        public void Apply(string aCompany, string aMajor) { }
        public void ChangeCompany() { }

        public override string ToString()
        {
            return "Intern Name: " + this.name + ", Major: " + this.major + "----";
        }
    }
}
