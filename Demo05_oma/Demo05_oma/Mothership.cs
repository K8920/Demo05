using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05_oma
{
    class Mothership
    {
        public float VespineGas { get; set; }
        public float Health { get; set; }
        public string Pilot { get; set; }

        private Drone drone = new Drone();

        ~Mothership()
        {
            Console.WriteLine("Mothership has been destroyed!");
        }
      
        public void Status()
        {
            Console.WriteLine("Pilot: " + Pilot + " " +"Health: " + Health + " " + "VespineGas: " + VespineGas);
        }
    }
}
