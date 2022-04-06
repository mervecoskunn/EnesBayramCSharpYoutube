using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Car
    {
        public int carDoorCounter;
        public string carModel ;
        public string carColor;



        public void startCar()
        {
            Console.WriteLine("Car running...");

        }
        public void lockTheDoors()
        {
            Console.WriteLine("Doors are locking...");
        }


    }
}
