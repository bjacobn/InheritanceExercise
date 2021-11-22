using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{

    // DONE- Create a class Bird
    // DONE - give this class 4 members that are specific to Bird
    // DONE -Set this class to inherit from your Animal Class

    public class Bird : Animal
    {
        //Properties
        public string BirdName { get; set; }
        public int  WingSpan { get; set; }
        public string FeatherColor { get; set; }
        public string VocalSound { get; set; }
        

        //Constructor
        public Bird()
        {
        }

        public void PrintBirdDetials()
        {
            Console.WriteLine("About : BlueJays \n");

            Console.WriteLine($"{BirdName} live in the {Habitat},feed on {Diet} and live on average of {LifeSpan} years.\n");


            Console.WriteLine($"Its {HasVertebrate} they are vertebrate with {FeatherColor} feathers and wingspan of {WingSpan} inches.\n");

           Console.WriteLine($"When out for walk and you hear a {VocalSound} a BlueJay may be close.\n");

          
            
        }

    }
}
