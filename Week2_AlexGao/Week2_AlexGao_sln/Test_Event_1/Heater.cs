using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Event_1
{
    class Heater
    {
        public int Temprature = 20;

        public delegate void DelegateHandle(int t);
        public event DelegateHandle HeatEventName;

        public void Heat(int temp)
        {
            //do { temp++; } while (temp > 95); 
            temp = 96;

            if (temp >95)
            {
                HeatEventName(96);
            }
        }
    }
}
