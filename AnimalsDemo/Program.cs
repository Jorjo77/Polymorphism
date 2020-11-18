using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Snake();

            
            if (animal is Snake)// това е за is - a
            {
                Console.WriteLine("Zyma");
            }
            Animal animal2 = new Cat();
            if (animal is Cat)// това е за is - a
            {
                Console.WriteLine("Keta");
            }
            Cat cat = new Cat();//може и н обратното за is-a (t.e. не само проверка родител-дете, а и обратното!):
            if (cat is Animal)
            {
                Console.WriteLine("Keta e animal");
            }
            Human catLover = new Human(new Dog());
            Human snakeHater = new Human(animal);

            while (true)
            {
                Console.ReadLine();
                catLover.Feed();
                catLover.PutToSleap();
                snakeHater.Feed();
                snakeHater.PutToSleap();
            }
        }
    }
}
