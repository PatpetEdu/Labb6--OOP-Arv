namespace Labb6__OOP_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            ZooInfo zoo = new ZooInfo();
            zoo.ShowTimeInfo(2023,8,9,9,00,17,00);
            Console.WriteLine("Here is a some details of the animals you can expect to see at our zoo and where to find them");

            Elephant elephant = new Elephant("Dumbo","Elephant", "Safari Park", 13, "Grey", 3500, " Bananas",15);
            elephant.AnimalInfo();
            elephant.whereTofind();
            elephant.tuskLenght();
            elephant.makeSound();
            elephant.feedingTime(2023, 10, 19, 10, 30);
            Shark shark = new Shark("Spikey","Shark", "Marine Life Exhibit", 20, "Grey", 700, "Fish","Dorsalfin");
            shark.AnimalInfo();
            shark.whereTofind();
            shark.finType();
            shark.makeSound();
            shark.feedingTime(2023, 10, 19, 11, 45);
            GreatWhiteShark whiteShark = new GreatWhiteShark("Nessie","Great White Shark", "Marine Life Exhibit", 11, "Grey and White", 1050, "Sea otter","Dorsalfin",58);
            whiteShark.AnimalInfo();
            whiteShark.whereTofind();
            whiteShark.SwimSpeed();
            whiteShark.finType();
            whiteShark.makeSound();
            whiteShark.feedingTime(2023, 10, 19, 12, 00);
            HammerHeadShark hammerHeadShark = new HammerHeadShark("Bulky","Hammer Head Shark", "Marine Life Exhibit", 15, "Grey and brown", 500, "Stingrays", "Cephalofoil", 0);
            hammerHeadShark.AnimalInfo();
            hammerHeadShark.whereTofind();
            hammerHeadShark.finType();
            hammerHeadShark.makeSound();
            hammerHeadShark.feedingTime(2023,10,19,12,15);
            Tiger tiger = new Tiger("Scar","Tiger", "Big Cat Enclosure", 10, "Orange", 150, "Meat",850);
            tiger.AnimalInfo();
            tiger.whereTofind();
            tiger.BiteForce();
            tiger.makeSound();
            tiger.feedingTime(2023, 10, 19, 9, 25);
            BengalTiger bengalTiger = new BengalTiger("Zimba","Bengal Tiger","Big Cat Enclosure", 20, "Black", 300, "Apple",1050,23);
            bengalTiger.AnimalInfo();
            bengalTiger.whereTofind();
            bengalTiger.BiteForce();
            bengalTiger.makeSound();
            bengalTiger.feedingTime(2023, 10, 19, 9, 30);

            bool validInput = false;
            while (!validInput)
            {

                Console.WriteLine("\nPlease choose the number of exhibition you would like to go to:");
                Console.WriteLine("1. Safari Park");
                Console.WriteLine("2. Marine Life Exhibit");
                Console.WriteLine("3. Big Cat Enclosure");
                string userInput = Console.ReadLine();
                int userChoice;
                if (int.TryParse(userInput, out userChoice))
                {
                    switch (userChoice)
                    {
                        case 1:
                            elephant.ExhibitionAct();
                            validInput = true;
                            break;
                        case 2:
                            shark.ExhibitionAct();
                            validInput = true;
                            break;
                        case 3:
                            tiger.ExhibitionAct();
                            validInput = true;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number");
                    
                }
            }
        }
    }
}