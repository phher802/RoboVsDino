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
        public Robot(string name)
        {
           this.robotName = name;
           robotHealth = 10;
           robotPowerLevel = 20;
           //robotWeaponType = robotWeaponType;
           robotAttackPower = 10;
        }

        // methods (can do)

        //1. have an ability to attack a dino
        //2. have ability to block an attack

        public void RobotAttack(Dinosaur dino)
        {
            dino.dinoHealth -= 1;
            dino.dinoEnergy -= 2;
            
                
            // random attack power later
        }

        public void RoboBlock()
        {
            //one block
        }
    }


}
