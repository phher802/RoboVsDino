using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinos
{
    class Robot
    {
        // member variables (HAS A)
        public string robotName;
        public int robotHealth;
        public int robotPowerLevel;
        public Weapon robotWeaponType;  //choose from a list? pre- determined or user input?
        public int robotAttackPower;


        // constructor (SPAWNER)
        public Robot(string name, int robotHealth, int robotAttackPower)
        {
            this.robotName = name;
            this.robotHealth = robotHealth;
            robotPowerLevel = 10;
            //robotWeaponType = robotWeaponType;
            this.robotAttackPower = robotAttackPower;
        }

        // methods (can do)

        //1. have an ability to attack a dino
        //2. have ability to block an attack

      
        public void RobotAttack(Dinosaur dino)
        {

            dino.dinoHealth *= 3;
            robotAttackPower -= 2;
            //dino.dinoEnergy -= 2;

        }
    }
       
}
