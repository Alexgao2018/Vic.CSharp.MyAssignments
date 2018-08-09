using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_AlexGao_proj
{
    class Person
    {
        static string Category = "Human";
        private string name;
        private int age;       
        
        public string Name { get; set; }
        public int Age { get; set; }

        public void Person_method_1() {
            Console.WriteLine("Person_method_1() is invoked");
        }

        public string ChangeCategory() {
            Console.WriteLine("--Base Class Person: I'm a person!");
            return "Person"; }
    }
}
