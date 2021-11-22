using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{

    // DONE - Create a class Animal
    // DONE - give this class 4 members that all Animals have in common

    public class Animal
    {
        public Animal()
        {
        }

        public string Habitat { get; set; }
        public int LifeSpan { get; set; }
        public string Diet { get; set; }
        public bool HasVertebrate { get; set; }
    }

}
