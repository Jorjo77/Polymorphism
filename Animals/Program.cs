using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Snake();
            Animal animal2 = new Cat();

            Human catLover = new Human(animal2);
            Human csnakeHater = new Human(animal);
        }
    }
}
