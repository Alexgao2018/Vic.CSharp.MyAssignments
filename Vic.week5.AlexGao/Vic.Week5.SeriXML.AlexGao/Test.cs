using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Vic.Week5.SeriXML.AlexGao
{
    public class Test
    {
        //C:\cs_01\Vic.week5.AlexGao\Vic.Week5.SeriXML.AlexGao\bin\Debug
        private static string xpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "Week5Test.xml");

        public static void MySerialiaze()
        {
            Person person = new Person();
            person.Name = "Tim";
            person.Sex = "Male";
            person.Age = 18;

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));

            try
            {
                Stream stream = new FileStream(xpath, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                xmlSerializer.Serialize(stream, person);
                stream.Close();
            }
            catch (Exception ex) {
                Console.WriteLine("----Write Xml Error 01  !");
                Console.ReadKey();
            }
        }

        public static void MyDeserialize()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));

            try
            {
                Stream stream = new FileStream(xpath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                Person person = (Person)xmlSerializer.Deserialize(stream);
                Console.WriteLine("--Person: Name: {0}, Sex: {1} Age:{2}", person.Name, person.Sex, person.Age);
            }
            catch (Exception ex)
            {
                Console.WriteLine("----Read Xml Error 02  !");
                Console.ReadKey();
            }         

        }
    }
}
