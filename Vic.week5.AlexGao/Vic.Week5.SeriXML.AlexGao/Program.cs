using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Vic.Week5.SeriXML.AlexGao
{
    class Program
    {
        static void Main(string[] args)
        {
            Test.MySerialiaze();

            Test.MyDeserialize();

            Console.ReadKey();
        }
    }
}
