using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.carDoorCounter = 4;
            car1.carColor = "Red";
            car1.carModel = "Tesla";
            car1.lockTheDoors();
            car1.startCar();
            Console.WriteLine("Counter car of doors: "+ car1.carDoorCounter);
            Console.WriteLine("Color of car: "+car1.carColor);
            Console.WriteLine("Model of car: "+ car1.carModel);
            Console.ReadLine();
            
        }
    }
}
