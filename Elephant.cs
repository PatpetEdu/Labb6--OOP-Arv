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
        public double _tuskSize;
        public Elephant(string name,string animalType, string exhibition, int age, string color, double weight, string food, double tuskSize) : base(name, age, color, weight,food,animalType,exhibition)
        {
            _tuskSize = tuskSize;       
        }
        public override void makeSound()
        {
            Console.WriteLine($"{_Name} lets out a loud trumpet sound");
        }
        public void tuskLenght()
        {
            Console.WriteLine($"Tusks: The elephants tusks are {_tuskSize} CM in lenght");
        }
        public void elephantExhibitionAct() //Metod som körs vid val av userinput i vårat switch case
        {
            Console.WriteLine($"You have arrived at the Safari Park to see the mighty elephant {_Name}, and lucky that you arrived right on feeding time");
        }
    }
}
