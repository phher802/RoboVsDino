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
           robotHealth = 5;
           robotPowerLevel = 10;
           //robotWeaponType = robotWeaponType;
           robotAttackPower = 5;
        }

        // methods (can do)

        //1. have an ability to attack a dino
        //2. have ability to block an attack


        public void RobotAttack(Dinosaur dino)
        {
            
            robotAttackPower -= 1;
            //dino.dinoHealth -= 1;
            //dino.dinoEnergy -= 2;
            //bool attack = Convert.ToBoolean(dino.dinoHealth -= 1);

            if (robotAttackPower == -1)
            {
                dino.dinoHealth -= 1;
                dino.dinoEnergy -= 2;

            }
        }

        public void RoboBlock()
        {
            //one block
        }
    }


}
