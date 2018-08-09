using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Driving Scenario in Real World 
/// 1). After a car stop very well, you can start and run
/// 2). After a car start, you can run
/// 3). After a car is running, you can stop it.
/// 
/// </summary>
namespace Vic.CSharp.Week4.AlexGao
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Driver driver = new Driver();

            //4 Events: EngineStarting, EngineStarted, EngineStopped, Running;

            //Add Methods
            //When a car stopped very well and driver want to go somewhere
            //Starting engine
            car.EngineStarting += (s, e) =>
                                            {
                                              Console.WriteLine("-----Car engine is Starting now!");
                                             };
            //car.EngineStarting += Driver.MyDeleagte.go(); //-<---add a delegate method ?? 
            //Mydelegate 
            driver.go();

            
            //Started the Engnie 
            car.EngineStarted += (s, e) =>
                                        {
                                         Console.WriteLine("-----Car engine Started now!");
                                        };

            //Stopped the Engnie 
            car.EngineStopped += (s, e) =>
                                        {
                                         Console.WriteLine("-----Car engine Stopped now!");
                                        };
           
            //Running if the Engine started
            car.Running += (s, e) =>
                                      {
                                         Console.WriteLine("-----Car is Running now!");
                                      };

            car.Run();

            car.Stop();

            Console.ReadKey();
        }
    }
}
