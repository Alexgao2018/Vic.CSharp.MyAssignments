using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vic.CSharp.Week4.AlexGao
{
    public class Driver
    {
        public string Name { get; set; } = "Alex";

        //public delegate void MyDriverDeleagte();

        public void go()
        {
            Console.WriteLine("\nClass Driver: Driver Name is {0}. ", Name);
        }
    }
}
