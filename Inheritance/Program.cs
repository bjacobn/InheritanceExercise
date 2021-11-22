using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------------BIRD-----------------------------

            /*DONE - *Create an object of your Bird class
             *DONE-  give values to your members using the object of your Bird class
             *  
             *DONE - Creatively display the class member values 
             */

            
            var blueJay = new Bird()
            {
                Habitat = "PineWoods of Florida",
                LifeSpan = 7,
                Diet = "Vegetation",
                HasVertebrate = true,
                BirdName = "BlueJays",
                WingSpan = 14,
                FeatherColor = "brown",
                VocalSound = "jeer",
                
            };

            blueJay.PrintBirdDetials();
            Console.WriteLine();


            //----------------------------REPTILE-------------------------
            
            /*DONE - Create an object of your Reptile class
             *DONE -  give values to your members using the object of your Reptile class
             *  
             * DONE -Creatively display the class member values 
             */

            
            var greenIguana = new Reptile()
            {
                Habitat = "Caribbean Islands",
                LifeSpan = 20,
                Diet = "Leaves",
                HasVertebrate = true,
                ReptileName = "Green Iguana",
                Scales = "overlapping",
                NumberEggsLays = 20,
                RunSpeed = 21
           };

            greenIguana.PrintReptileDetials();
            Console.WriteLine();
        }
    }
}
