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


        int dinoScore;
        int robotScore;

        // constructor (SPAWNER)
        public Battelfield()
        {
            herd = new Herd();
            fleet = new Fleet();

            dinoScore = 0;
            robotScore = 0;


        }

        // methods
  
        public void RoundOne()
        {

            //int dinoHealth = herd.dinoType[0].dinoHealth;
            //int dinoAttackPower = herd.dinoType[0].dinoAttackPower;

            //int roboHealth = fleet.robots[0].robotHealth;
            //int roboAttackPower = fleet.robots[0].robotAttackPower;

            //for loop to loop through each group's health points to reach zero

            for (int i = 0; i < 3; i++)
            {
                if (herd.dinoType[i].dinoHealth <= 0 || fleet.robots[i].robotHealth <= 0)
                {
                    if (herd.dinoType[i].dinoHealth <= i)
                    {
                        Console.WriteLine(fleet.robots[i].robotName + " Wins!");
                        robotScore++;
                        break;
                    }
                    else if (fleet.robots[i].robotHealth <= 0)
                    {
                        Console.WriteLine(herd.dinoType[i].dinoType + " Wins!");
                        dinoScore++;
                        break;
                    }

                }
                else if (herd.dinoType[i].dinoHealth == fleet.robots[i].robotHealth && herd.dinoType[i].dinoAttackPower == fleet.robots[i].robotAttackPower)
                {
                    herd.dinoType[i].DinoAttack(fleet.robots[i]);
                
                }
                else if (herd.dinoType[i].dinoHealth < fleet.robots[i].robotHealth || herd.dinoType[i].dinoAttackPower < fleet.robots[i].robotAttackPower)
                {
                    fleet.robots[i].RobotAttack(herd.dinoType[i]);
                
                }
                else if (herd.dinoType[i].dinoHealth > fleet.robots[i].robotHealth || herd.dinoType[i].dinoAttackPower > fleet.robots[i].robotAttackPower)
                {
                    herd.dinoType[i].DinoAttack(fleet.robots[i]);
             
                }
            

            }            

        }

        
        public void DisplayWinner()
        {
            if (dinoScore == 3)
            {
                Console.WriteLine("The Dinosaurs Wins!");
            }
            else if(robotScore == 3)
            {
                Console.WriteLine("The Robots Wins!");
            }

        }

        public void RunBattle()
        {
            RoundOne();
            RoundOne();
            RoundOne();

            DisplayWinner();

            Console.ReadLine();
        }
    }


}   
           












