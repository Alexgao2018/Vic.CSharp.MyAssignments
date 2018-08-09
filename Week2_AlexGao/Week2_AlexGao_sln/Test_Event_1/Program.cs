using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Event_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //--1----New
            Heater heater = new Heater();
            Alert alert = new Alert();
            Display display = new Display();

            //--2-----Add Event Methods?  or Delegate Methods?
            //heater. += alert.MakeAlert;
            heater.HeatEventName += alert.MakeAlert;
            heater.HeatEventName += Display.DisplayTemp;


            //--2---Run
            heater.Heat(5);

            Console.ReadKey();
        }
    }
}
