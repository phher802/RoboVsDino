using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinos
{
    class Fleet
    {
        // member variables (HAS A)
        public List<Robot> robots;

        // constructor (SPAWNER)
        public Fleet()
        {
            robots = new List<Robot>();

            if(robots == null)
            {
                for (int i = 0; i < 3; i++)
                {
                    Robot robot = new Robot(RobotName());

                    robots.Add(robot);
                }
            }
         
        }

        // methods (can do)
        public string RobotName()
        {
            Console.WriteLine("Name your Robot");
            string newRobot = Console.ReadLine();

            return newRobot;
        }

        
    }
}
