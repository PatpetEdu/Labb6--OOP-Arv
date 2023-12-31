﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Labb6__OOP_Arv
{
    public class Tiger : Animal
    {
        public double _BitForce;
        public Tiger(string name, string animalType, string exhibition, int age, string color, double weight, string food, int biteForce) : base(name, age, color, weight, food, animalType, exhibition)
        {
            _BitForce = biteForce;
        }
        public override void makeSound() //Skriver över befinlig metod från bas metoden
        {
            Console.WriteLine($"{_Name} makes a roaring sound");
        }
        public virtual void BiteForce()
        {
          Console.WriteLine($"A tiger has a bitforce of {_BitForce} Psi");
        }

        public override void ExhibitionAct()
        {
            Console.WriteLine($"You found your way to the Big Cat Enclosure too get a look of {_Name} but unforutnatly he is very shy today and are hiding somwhere");
        }
    }
    public class BengalTiger : Tiger 
    {
        public double _Stripes;
        public BengalTiger(string name,string animalType,string exhibition, int age, string color, double weight, string food, int biteForce,int stripes) : base(name,animalType,exhibition, age, color, weight, food,biteForce)
        {
            _Stripes = stripes;
        }
        public override void BiteForce()
        {
            Console.WriteLine($"A bengal tiger has a bitforce of {_BitForce} Psi");
        }
        public override void makeSound()
        {
            Console.WriteLine($"{_Name} makes a fierce roar!");
        }
    }
}
