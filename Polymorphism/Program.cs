using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape baseClass = new Rectangle() { };
            Console.WriteLine(baseClass.Area());
            baseClass = new Square();
            Console.WriteLine(baseClass.Area());
        }
    }
}
