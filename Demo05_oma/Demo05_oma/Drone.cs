using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05_oma
{
    class Drone
    {
        public float Health { get; set; }
        public string Name { get; set; }

         ~Drone()
         {
         Console.WriteLine(Name + " " + "Has been destroyed!");
         }
      
        public void DroneStatus()
        {
            Console.WriteLine("Health: " + Health + " " + "Name: " + Name);
        }
    }
}
