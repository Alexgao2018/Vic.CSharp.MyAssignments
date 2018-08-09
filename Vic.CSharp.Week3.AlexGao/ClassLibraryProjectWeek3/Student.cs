using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryProjectWeek3
{
    //class Student
    //{
    //}
    class Student : Person
    {      
        public string Name { get; set; }
        //public int Age { get { return age; } set { age = value; } } //----Event ChangeAge
        public int ID { get; set; }
        public string Addr { get; set; }

        //public void SetAge(int n) {
        //    age = n;
        //    EventPublisher_1 eventPublisher_1 = new EventPublisher_1();
        //    eventPublisher_1.
        //    //OnAgeChanged();
        //}

        public static void StaticMethod()
        {
            Console.WriteLine("++Student: Static Method Invoke---");
        }

        public void Student_Method_1()
        {
            Console.WriteLine("Student_method_1() is invoked");
        }

        //Class: Polymorphism
        public new string ChangeCategory()
        {
            Console.WriteLine("--SubClass Student: Override--I'm a student!");
            return "Student";
        }


        //public bool Register(string stuName, int stuID, string stuAddr) {
        public void Register()
        {
            Console.WriteLine("--Student: Method Register--- Intance Method Invoke---");
            //return true;
        }

        //public void Pay(int stuID, decimal stuFee) {
        public void Pay()
        {
            Console.WriteLine("--Student: Method Pay -- Intance Method Invoke---");
            //return 678;
        }
        //public void ChangeAddr() { }

        public override string ToString()
        {
            //return "Student Name: " + this.name + ", Age: " + (string)this.age + "----";
            //Console.WriteLine("00000000000000 " + this.name);
            //string str = this.age.ToString;
            return "Student Name: " + this.name + "----";
        }
    }
}
