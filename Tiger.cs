using System;
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
        public Tiger(string name, int age, string color, double weight, string food) : base(name, age, color, weight, food)
        {
        }     
        public override void makeSound()
        {
            Console.WriteLine("The tiger makes a roaring sound");
        }
    }
    public class BengalTiger : Tiger 
    {
        public double BitForce;
        public BengalTiger(string name, int age, string color, double weight, string food, int biteForce) : base(name, age, color, weight, food)
        {
            BitForce = biteForce;

        }
        public void BiteForce()
        {
            Console.WriteLine($"A bengal tiger has a bitforce of {BitForce} Psi");
        }


    //}
    //public class SiberianTiger : Tiger
    // public string 
    //{

    }
}
