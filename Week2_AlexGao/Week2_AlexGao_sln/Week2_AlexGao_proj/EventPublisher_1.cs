using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_AlexGao_proj
{
    class EventPublisher_1
    {
        //Publisher
        // Delegate Name: Myhandle
        // Event Name   : EventName_ChangAge
        // Active Condation(): 

        private int value = 6;
        public delegate void MyHandle();
        public event MyHandle EventName_SetValue;

        public void SetValue(int n) {
            value = n;
            OnValueChanged();
        }

        public void OnValueChanged() {
            if (EventName_SetValue != null) {
                EventName_SetValue();  //-----Active---
            } else {
                Console.WriteLine("----The Event do NOT actived!---");
                Console.ReadKey();
            }

        }
    }
}
