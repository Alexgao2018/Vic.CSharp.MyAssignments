using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-------------(ver 1.0) Week 2
namespace Week2_AlexGao_proj
{
    class Program
    {
        /// <summary>
        ///         C# Code Feathures (ver 1.0) Week 2
        /// ======================================================
        /// 1) Class(Abstract/Sealed): 
        ///         Encapsulation, 
        ///         Inheritance, 
        ///         Polymorphism 
        /// 2) Property Accesss:
        /// 3) Methods: (virtual method in base class)
        /// 4) Indexer: 
        /// 5) Override Operator/ToString:
        /// 6) Thread             
        /// 7) Interface: 4/4(Property, Method, Event, Indexer)
        /// 8) Delegate: 
        /// 9) Event: Publisher, Subscriber, (???)
        /// 10) Partial, 
        ///     Try { } catch (){}
        ///     Parall??
        /// 11) Reflection
        /// 12) Generic <T>
        /// 
        /// </summary>

        public delegate void MyStudentDelegateHandle();
        public delegate void MyTeacherDelegateHandle();

        static void Main(string[] args)
        {
            /*  1) Class(Abstract / Sealed): 
                     Encapsulation, 
                     Inheritance, 
                     Polymorphism (virtual/override, new, base.PersonMothod)  
                     
                    Class Teacher : Person {}
                    Class Student : Person {}
                    Class Intern  : Student : Person {}
             */
            Console.WriteLine("\n\n1)===Class Inheritance, Polymorphism===");
            Person person = new Student();
            person.ChangeCategory();

            Student student1 = new Student();
            Person person1 = (Person)student1;
            person1.Person_method_1();

            Student student2 = new Student();
            student2.Student_Method_1();
            Person person2 = new Person();
            //new (Student)person2.Person_method_1();

            //Teacher teacher1 = new Teacher();
            //teacher1.Teacher_Method_1();
            //(Student)teacher1.

            // 2) Property Accesss:




            // 3) Methods: (virtual method in base class)




            // 4) Indexer: 



            // 5) Override Operator/ToString:
            Console.WriteLine("\n\n5)=== Override Operator/ToString: Student.ToString()===");
            Student student5 = new Student();
            Console.WriteLine("Student.ToString()==="  + student5.ToString());



            // 6) Thread 



            // 7) Interface: 4/4(Property, Method, Event, Indexer)



            // 8) Delegate:             
            //public delegate void MyStudentDelegateHandle();
            //public delegate void MyTeacherDelegateHandle();
            Student student = new Student();
            Teacher teacher = new Teacher();

            Console.WriteLine("\n\n8)==Delegate==============Same Class 2 Methods========");
            //MyStudentDelegateHandle myStuDelegateHandle = new MyStudentDelegateHandle(student.Register("Tom",9988,"2025 St Marc"));
            MyStudentDelegateHandle myStudentDelegateHandle = new MyStudentDelegateHandle(student.Register);
            myStudentDelegateHandle += Student.StaticMethod;
            myStudentDelegateHandle();

            Console.WriteLine("\n\n8)==Delegate==============Different Class 2 Methods========");
            myStudentDelegateHandle += Teacher.StaticMethod;
            myStudentDelegateHandle += student.Pay;
            myStudentDelegateHandle();

            Console.WriteLine("\n\n8)==Delegate==============Remove a Method========");
            myStudentDelegateHandle -= student.Register;
            myStudentDelegateHandle();

            Console.WriteLine("\n\n8)==Delegate==New Delegate, Different Class Method========");
            MyTeacherDelegateHandle myTeacherDelegateHandle = new MyTeacherDelegateHandle(student.Register);
            myTeacherDelegateHandle();


            // 9) Event: Publisher, Subscriber, (Story)
            Console.WriteLine("\n\n9)==Event=============");
            EventPublisher_1 p1 = new EventPublisher_1();
            EventSubscriber_1 s1 = new EventSubscriber_1();

            //Event: Add a Method
            p1.EventName_SetValue += new EventPublisher_1.MyHandle(s1.printAgeChangedMessage);
            //p1.EventName_SetValue += new EventPublisher_1.MyHandle(p1.EventName_SetValue);

            //(story)---ACtive---
            p1.SetValue(99);



            // 10) Partial, 
            //     Try { } catch (){}


            //     Parallel
            //     
            // 
            // 11) Reflection

            // 12) Generic <T>


            Console.ReadKey();
    }
    }
}
