using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinos
{
    class Herd
    {
        // member variables (HAS A)
        public List<Dinosaur> dinoType;


        // constructor (SPAWNER)
        public Herd()
        {
      
            dinoType = new List<Dinosaur>();

          
                Dinosaur tRex = new Dinosaur("tRex", 10, 5);
                Dinosaur spino = new Dinosaur("Spinosaurus", 10, 5);
                Dinosaur allo = new Dinosaur("Allosaurus", 10, 5);
                dinoType.Add(tRex);
                dinoType.Add(spino);
                dinoType.Add(allo);
            
        }


        //methods
       
    }
 }



    
        
        // methods (can do)
        //public string TypeOfDino()
        //{
        //    //name the dino
        //    Console.WriteLine("Enter a type of dinosaur");
        //    string typeName = Console.ReadLine();

        //    return typeName;

            
        //}

        //public void DinoList()
        //{
        //    dinoType = new List<Dinosaur>();

        //    for (int i = 0; i < 3; i++)
        //    {
        //        Dinosaur dino = new Dinosaur(TypeOfDino(), 5, 5);

        //        dinoType.Add(dino);

        //        //how to add a dino to the list and pass in name at the same time
        //    }

        //}
    

