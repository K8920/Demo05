using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05_oma
{
    class Program
    {
        static void Main(string[] args)
        {
                Mothership mothership = new Mothership();
                mothership.Health = 100;
                mothership.VespineGas = 500;
                mothership.Pilot = "Artanis";

                Drone drone1 = new Drone();
                drone1.Health = 100;
                drone1.Name = "Drone nr.1";

                Drone drone2 = new Drone();
                drone2.Health = 100;
                drone2.Name = "Drone nr.2";

                Drone drone3 = new Drone();
                drone3.Health = 100;
                drone3.Name = "Drone nr.3";

                Drone drone4 = new Drone();
                drone4.Health = 100;
                drone4.Name = "Drone nr.4";

                mothership.Status();
                Console.WriteLine("-----------------------------------------------");
                drone1.DroneStatus();
                drone2.DroneStatus();
                drone3.DroneStatus();
                drone4.DroneStatus();
                Console.WriteLine("-----------------------------------------------");
                Console.ReadLine();
        }
    }
}
