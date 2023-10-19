namespace Labb6__OOP_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ZooInfo zoo = new ZooInfo();
            zoo.ShowTimeInfo(2023,8,9,9,00,17,00);


            Elephant elephant = new Elephant("Dumbo", 13, "Grey", 3500, " Bananas");
            elephant.AnimalInfo();
            elephant.makeSound();
            elephant.feedingTime(2023, 10, 19, 10, 30);
            Shark shark = new Shark("Spikey", 20, "Grey", 700, "Fish");
            shark.AnimalInfo();
            shark.makeSound();
            shark.feedingTime(2023, 10, 19, 11, 45);
            GreatWhiteShark WhiteShark = new GreatWhiteShark("Nessie", 11, "Grey and White", 1050, "Sea otter",0);
            WhiteShark.AnimalInfo();
            WhiteShark.SwimSpeed();
            WhiteShark.makeSound();
            WhiteShark.feedingTime(2023, 10, 19, 12, 00);
            Tiger tiger = new Tiger("Scar", 10, "Orange", 150, "Meat");
            tiger.AnimalInfo();
            tiger.makeSound();
            tiger.feedingTime(2023, 10, 19, 9, 25);
            BengalTiger bengalTiger = new BengalTiger("Zimba", 20, "Black", 300, "Apple",1050);
            bengalTiger.AnimalInfo();
            bengalTiger.BiteForce();
            bengalTiger.feedingTime(2023, 10, 19, 9, 30);


            //Krav om att kunna ska ett nytt djur med hjälp av konstruktor
            //Animal MyNewAnimal = new Animal("Pumba", 20, "Brown", 120, "Rodents");
            //MyNewAnimal.AnimalInfo();
        }
    }
}