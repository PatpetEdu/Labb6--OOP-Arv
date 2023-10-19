using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Labb6__OOP_Arv
{
    internal class Elephant : Animal
    {
        public Elephant(string name, int age, string color, double weight, string food) : base(name, age, color, weight,food)
        {    
        }
        public override void makeSound()
        {
            Console.WriteLine("The elephant lets out a loud trumpet sound");
        }
    }
}
