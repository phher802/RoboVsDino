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
        string robotName;
        int robotHealth;
        int robotPowerLevel;
        string robotWeaponType;  //make into list?
        int robotAttackPower;


        // constructor (SPAWNER)
        public Robot(string name, string robotWeaponType)
        {
           this.robotName = name;
           robotHealth = 10;
           robotPowerLevel = 10;
           this.robotWeaponType = robotWeaponType;
           robotAttackPower = 10;
        }

        // methods (can do)
    }
}
