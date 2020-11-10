using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinos
{
    class Battelfield
    {
        // member variables (HAS A)
        public Herd herd;
        public Fleet fleet;
        bool isAttacked;

        // constructor (SPAWNER)
        public Battelfield()
        {
            
            herd = new Herd();
            fleet = new Fleet();           
            
        }


        // methods (can do)

        //give robot and dino ability to attack each other

        //have one object from each herd/fleet battle?

        public void BattleRun()
        {
            // for loop to loop through each group's health points to reach zero

            herd.dinoType[0].DinoAttack(fleet.robots[0]);




        }






    }

}

