﻿using System;
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
          
         
            Robot franky = new Robot("Franky", 10, 5);
            Robot nano = new Robot("Nano", 10, 5);
            Robot doraemon = new Robot("Doraemon", 10, 5);

            robots.Add(franky);
            robots.Add(nano);
            robots.Add(doraemon);         

        }

       
        
    }
}
