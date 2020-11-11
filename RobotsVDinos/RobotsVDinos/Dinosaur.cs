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
        public Dinosaur(string dinoType, int dinoHealth, int dinoAttackPower)
        {
            this.dinoType = dinoType;
            this.dinoHealth = dinoHealth;
            dinoEnergy = 10;
            this.dinoAttackPower = dinoAttackPower;
        }

        // methods (can do)


        public void DinoAttack(Robot robot)
        {

            robot.robotHealth *= 2;
            dinoAttackPower -= 1;
       

        }
    }
}
