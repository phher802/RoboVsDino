using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinos
{
    class Dinosaur
    {
        // member variables (HAS A)
        public string dinoType;
        public int dinoHealth;
        public int dinoEnergy;
        public int dinoAttackPower;

        // constructor (SPAWNER)
        public Dinosaur(string dinoType)
        {
            this.dinoType = dinoType;
            dinoHealth = 10;
            dinoEnergy = 20;
            dinoAttackPower = 10;
        }

        // methods (can do)
        
        public void DinoAttack(Robot robot)
        {
            robot.robotHealth -= 1;
            robot.robotPowerLevel -= 2;
           
        }
    }
}
