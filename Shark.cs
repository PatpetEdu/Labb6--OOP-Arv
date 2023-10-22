using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Labb6__OOP_Arv
{
   public class Shark : Animal
    {
        public string _finType;
        public Shark(string name, string animalType, string exhibition, int age, string color, double weight, string food,string finType) : base(name, age, color, weight, food, animalType, exhibition)
        {
            _finType = finType;
        }
        public override void makeSound()
        {
            Console.WriteLine("Sharks can actually make sounds but it's not audible to humans.");
        }
        public virtual void finType()
        {
            Console.WriteLine("characteristic traits: Sharks have dirrent types of fins but the most prominent one is the Dorsal Fin. \nA (general) shark typically has a tall, triangular dorsal fin on its back. This dorsal fin aids in stability and steering while swimming. It is one of the most recognizable features of a shark's silhouette.");
        }
        public void sharkExhibitionAct() //Metod som körs vid val av userinput i vårat switch case
        {
            Console.WriteLine($"A the Marine Life Exhibit you see the shark {_Name} chasing after a big fish, wondering if he will actually catch it.");
            Random random = new Random();
            int randomCatch = random.Next(0, 2); //slumpar från en 50/50 chans om hajen ska fånga fiksen eller inte
            if (randomCatch == 0)
            {
                Console.WriteLine($"To your big suprise {_Name} catches the fish right infront of your eyes. A moment you will definatly rember.");
            }
            else
            {
                Console.WriteLine($"Unforunatly for {_Name} he swims away empty-handed, the big fish manged to escape.");
            }
        }
    }
    public class GreatWhiteShark : Shark
    {
        public double _SwimSpeed = 56;
        public GreatWhiteShark(string name,string animalType, string exhibition,int age, string color, double weight, string food,string finType, double swimSpeed) : base(name,animalType,exhibition,age, color, weight, food, finType)
        {
            _SwimSpeed = swimSpeed; 
        }
        public override void finType()//metod för fentyp
        {
            Console.WriteLine("characteristic traits: The dorsal fin of a great white shark is particularly large and rigid, helping it maintain balance and stability.");
        }
        public void SwimSpeed() //metod för swim hastighet
        {
            Console.WriteLine($"Swim speed: A Great White Shark can have a maximum swim speed of up to {_SwimSpeed} km/h");
        }
    }
    public class HammerHeadShark : Shark
    {
        public HammerHeadShark(string name, string animalType, string exhibition, int age, string color, double weight, string food, string finType, double swimSpeed) : base(name, animalType,exhibition,age, color, weight, food, finType)
        {
         
        }
        public override void finType()
        {
            Console.WriteLine("characteristic traits: One of the most distinctive features of a hammerhead shark is its cephalofoil, which is the wide, flattened head with eyes positioned at the ends. The cephalofoil is an adaptation that provides better vision and improved maneuvering ability.");
        }
    }
}
