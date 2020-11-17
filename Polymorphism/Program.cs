using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Polymorphism - ability of an object to take on many forms (може да бъде от типа на всички които го наслеяват). Пример:
            //Polymorphism е един и същи обект да прави различни неща
            //Polymorphism  ни помага програмата ни да е по лека, по четима!
            //Polymorphism има навсякъде в ООП -то, всички дженерик неща са полиморфизъм.
            // От ляво слагаме(работим с) базовия тип, а отдясно може да бъдат всички наследници на базовия клас! Така много лесно може да се променя функционалността!(с различен инпут, baseClass.Area() прави различни неща)

            //Със Polymorphism (с различен инпут, baseClass.Area() прави различни неща)

            //abstract метод може да има само в абстракт клас и няма имплементация. Виртуал метода е във нормален(неабстрактен клас) и има имплементаця. После и двата метода се оверрайдват в класовете наследници!   

            //ключовата дума is проверява типа на обекта, демо в IsKeyword и в Animals!

            //Ако ни се наложи много да използваме is (да проверяваме кой ой е) това заначи че нещо кода ни не е добе, това не е добър полиморфиъм! Може да ни сеструва че това ни решава проблемите, но не е така, това ни прави проблемите! Това се прави така в кайни случаи - когто тестваме нещо или ако другите го правт така - в общи лини това се счита за лоша практика (проверките кой кой е в Animals за IsKeyword) - така губим целия полиморфизъм!
            // В Program показваме как с помощта на Is можем да кастнем shape към Rectangle!

            //Можем да вземем пропъртитата на конкретен обект като го кастнем! Пример за кастване:
            //((Snake)Pet)
            //(Pet as Snake)
            //Разликата между двата вида кастване е че при кастването с as ако не успее ще върне нула, а другото гърми!
            Shape shape = new Rectangle();
            if (shape is Rectangle)
            {
                Rectangle rectangle = (Rectangle)shape;
                ((Rectangle)shape)//така можем да кастнем shape към Rectangle!
            }
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
