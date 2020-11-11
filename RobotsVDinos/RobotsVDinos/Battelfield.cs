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

            int dinoHealth = herd.dinoType[0].dinoHealth;
            int dinoAttackPower = herd.dinoType[0].dinoAttackPower;

            int roboHealth = fleet.robots[0].robotHealth;
            int roboAttackPower = fleet.robots[0].robotAttackPower;

            //for loop to loop through each group's health points to reach zero

            for (int i = 0; i < 7; i++)
            {
                if (dinoHealth <= 0 || roboHealth <= 0)
                {
                    if (dinoHealth <= 0)
                    {
                        Console.WriteLine("Franky Wins!");
                        robotScore++;
                        break;
                    }
                    else if (roboHealth <= 0)
                    {
                        Console.WriteLine("T-Rex Wins!");
                        dinoScore++;
                        break;
                    }

                }
                else if (dinoHealth == roboHealth && dinoAttackPower == roboAttackPower)
                {
                    herd.dinoType[0].DinoAttack(fleet.robots[0]);
                    roboHealth -= 2;
                    dinoAttackPower -= 1;

                }
                else if (dinoHealth < roboHealth || dinoAttackPower < roboAttackPower)
                {
                    fleet.robots[0].RobotAttack(herd.dinoType[0]);
                    dinoHealth -= 2;
                    roboAttackPower -= 1;

                }
                else if (dinoHealth > roboHealth || dinoAttackPower > roboAttackPower)
                {

                    herd.dinoType[0].DinoAttack(fleet.robots[0]);
                    roboHealth -= 2;
                    dinoAttackPower -= 1;

                }
                else if (dinoHealth < roboHealth || dinoAttackPower > roboAttackPower)
                {
                    fleet.robots[0].RobotAttack(herd.dinoType[0]);
                    dinoHealth -= 2;
                    roboAttackPower -= 1;
                    herd.dinoType[0].DinoAttack(fleet.robots[0]);
                    roboHealth -= 2;
                    dinoAttackPower -= 1;
                }


            }

            

        }

        public void DisplayWinner()
        {
            if (dinoScore == 3)
            {
                Console.WriteLine("The Dinosaurs Wins!");
            }
            else
            {
                Console.WriteLine("The Robots Wins!");
            }

        }


    }


}   
           //herd.dinoType[0].DinoAttack(fleet.robots[0]);


        
        //public void BattleRun()
        //{

        //}








}   



