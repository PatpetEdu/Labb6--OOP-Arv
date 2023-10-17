using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Labb6__OOP_Arv
{
    internal class Animal
    {
        //Egenskaper hos Djuret
        private string _Name { get; set; }
        private int _Age { get; set; }
        private string _Color { get; set; }
        private double _Weight { get; set; }
        private string _FaveFood { get; set; }

        public Animal()
        {

        }
        public Animal(string name, int age, string color, double weight, string food)
        {
            _Name = name;
            _Age = age;
            _Color = color;
            _Weight = weight;
            _FaveFood = food;
        }
        public virtual void AnimalInfo()
        {
            Console.WriteLine($"\nName: {_Name} \nAge: {_Age} \nColor: {_Color} \nWeight in Kilograms: {_Weight} \nFavorite food: {_FaveFood}");
        }

        public void makeSound()
        {

        }
        public void feeding()
        {

        }
    }

}
