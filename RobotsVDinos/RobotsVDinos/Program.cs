using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinos
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robotOne = new Robot("Mecha", "LaserBeam");
            Robot robotTwo = new Robot("Franky", "AirPistol");
            Robot robotThree = new Robot("Carmen", "HandGun");

            Dinosaur dinoOne = new Dinosaur("tRex");
            Dinosaur dinoTwo = new Dinosaur("Spinosaurus");
            Dinosaur dinoThree = new Dinosaur("Velociraptor");
        }
    }
}
