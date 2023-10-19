using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6__OOP_Arv
{
   public class Shark : Animal
    {
        public Shark(string name, int age, string color, double weight, string food) : base(name, age, color, weight, food)
        {
        }
        public override void makeSound()
        {
            Console.WriteLine("The shark makes an inaudible sound");
        }
    }
    public class GreatWhiteShark : Shark
    {
        public double _SwimSpeed = 56;
        public GreatWhiteShark(string name, int age, string color, double weight, string food, double swimSpeed) : base(name, age, color, weight, food)
        {
            _SwimSpeed = swimSpeed; 
        }
        public void SwimSpeed()
        {
            Console.WriteLine($"A Great White Shark can have a maximum swim speed of up to {_SwimSpeed} km/h");
        }
    }
}
