using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{

    // DONE - Create a class Reptile
    // DONE - give this class 4 members that are specific to Reptile
    // DONE - Set this class to inherit from your Animal Class


    public class Reptile : Animal
    {
        //Properties
        public string ReptileName { get; set; }
        public string Scales { get; set; }
        public int NumberEggsLays{ get; set; } 
        public int RunSpeed { get; set; }


        //Constructor
        public Reptile()
        {
        }


        public void PrintReptileDetials()
        {
            Console.WriteLine("About : Green Iquana \n");

            Console.WriteLine($"{ReptileName} live in the {Habitat},feed on {Diet} and live on average of {LifeSpan} years.\n");


            Console.WriteLine($"It is {HasVertebrate} they are vertebrate with {Scales} scales, and can run {RunSpeed} miles per hour.\n");
        }
    } 
}




