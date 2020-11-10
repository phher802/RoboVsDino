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
            dinoHealth = 5;
            dinoEnergy = 10;
            dinoAttackPower = 5;
        }

        // methods (can do)


        //public void DinoAttack(Robot robot)
        //{
        //    dinoAttackPower -= 1;
        //    //robot.robotHealth -= 1;
        //    //robot.robotPowerLevel -= 2;
        //    //bool attack = Convert.ToBoolean(robot.robotHealth -= 1);

        //    if (dinoAttackPower == -1)
        //    {
        //        robot.robotHealth -= 1;
        //        //robot.robotPowerLevel -= 2;

        //    }

        //}
    }
}
