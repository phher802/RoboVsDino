using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinos
{
    class Battelfield
    {
        // member variables (HAS A)
        Herd herd;
        Fleet fleet;
        bool isAttacked;

        // constructor (SPAWNER)
        public Battelfield()
        {
            herd = new Herd();
            fleet = new Fleet();

            
        }


        // methods (can do)

        //give robot and dino ability to attack each other
        //when a robot attacks a dino, dino will lose a health point and 2 energy points
        // then robot attack level will decrease by one point
        // when dino attacks a robot, robot will lose a health point and 2 power levels
        // then dino attack level will decrease one point
     
    

        public void DinoAttack(Robot robot)
        {
            robot.robotHealth -= 1;
            //robot.robotPowerLevel -= 2;
        }

        public void RobotAttack(Dinosaur dino)
        {
            dino.dinoHealth -= 1;
            //dino.dinoEnergy -= 2;


            // random attack power later
        }

        
    }
    }
}
