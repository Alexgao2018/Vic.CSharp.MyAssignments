using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vic.CSharp.Week4.AlexGao
{
    public class Car   //--<----Publisher
    {
        public string Name { get; set; } = "Alex";

        //public delegate void MyCarDelegate();
        public event EventHandler EngineStarting, EngineStarted, EngineStopped, Running;

        public void Run()
        {
            if (EngineStarting != null)
            {
                EngineStarting(this, EventArgs.Empty);
                EngineStarted(this, EventArgs.Empty);
                Running(this, EventArgs.Empty);
            }
        }

        public void Stop()
        {
            if (EngineStopped != null)
            {
                EngineStopped(this, EventArgs.Empty);
            }
        }

        public void go()
        {
            Console.WriteLine("\n Driver Name is {0}: ", Name);
        }
    }
}
