using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Polymorphism - ability of an object to take on many forms (може да бъде от типа на всички които е наследил). Пример:
            //Polymorphism е един и същи обект да прави различни неща
            //Polymorphism  ни помага програмата ни да е по лека, по четима!
            //Polymorphism има навсякъде в ООП -то, всички дженерик неща са полиморфизъм.
            // От ляво слагаме(работим с) базовия тип, а отдясно може да бъдат всички наследници на базовия тип! Така много лесно може да се променя функционалността!(с различен инпут, baseClass.Area() прави различни неща)

            //Със Polymorphism (с различен инпут, baseClass.Area() прави различни неща)
            string input = Console.ReadLine();
            while (true)
            {

                Shape baseClass = null;
                if (input == "square")
                {
                    baseClass = new Square() { A = 3 };
                }
                else
                {
                    baseClass = new Rectangle() { A = 5, B = 6 };

                }

                Console.WriteLine(baseClass.Area());
            }

            //Без Polymorphism (положението е доста по-зле, а ако имахме и триъгълник, кръг!?):
            //string input = Console.ReadLine();
            //while (true)
            //{

            //    Rectangle rectangle = null;
            //    Square square = null;
            //    if (input == "square")
            //    {
            //        square = new Square() { A = 3 };
            //    }
            //    else
            //    {
            //        rectangle = new Rectangle() { A = 5, B = 6 };

            //    }

            //    if (square == null)
            //    {
            //        Console.WriteLine(rectangle.Area());
            //    }
            //    else
            //    {
            //        Console.WriteLine(square.Area());
            //    }
            //}
        }
    }
}
