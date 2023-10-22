using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Labb6__OOP_Arv
{
    public abstract class Animal
    {
        //Egenskaper hos Djuret
        protected string _Name { get; set; }
        private int _Age { get; set; }
        private string _Color { get; set; }
        private double _Weight { get; set; }
        private string _FaveFood { get; set; }
        private string _AnimalType { get; set; }
        private DateTime _Foodtime { get; set;}
        private string _Exhibition { get; set; }

        public Animal(string name, int age, string color, double weight, string food, string animalType,string exhibition)
        {
            //defaultvärden för mina egenskaper
            _Name = name;
            _Age = age;
            _Color = color;
            _Weight = weight;
            _FaveFood = food;
            _AnimalType = animalType;
            _Exhibition = exhibition;
        }
        public void AnimalInfo()
        {
            Console.WriteLine($"\nAnimal type: {_AnimalType} \nName: {_Name} \nAge: {_Age} \nColor: {_Color} \nWeight: {_Weight} Kg \nFavorite food: {_FaveFood}");
        }
        public void whereTofind()
        {
            Console.WriteLine($"{_Name} can be found in the {_Exhibition} exhibition.");  
        }

        public virtual void makeSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
        public void feedingTime(int year, int month, int day,int hour, int minute)
        {
           
            _Foodtime = new DateTime(year,month, day,hour,minute,0);
            Console.WriteLine($"{_Name} is scheduled to be fed at {_Foodtime:yyyy-MM-dd HH:mm}"); //Included :yyyy-MM-dd HH:mm to not print the seconds 
        }
    }

}
