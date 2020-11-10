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
        public string robotWeaponType;  //make into list?
        public int robotAttackPower;


        // constructor (SPAWNER)
        public Robot(string name)
        {
           this.robotName = name;
           robotHealth = 10;
           robotPowerLevel = 10;
           robotWeaponType = robotWeaponType;
           robotAttackPower = 10;
        }

        // methods (can do)
    }
}
