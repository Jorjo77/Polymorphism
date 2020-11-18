﻿using System;

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
            // От ляво слагаме(работим с) базовия клас/интерфейс, а отдясно може да бъдат всички наследници на базовия клас! Така много лесно може да се променя функционалността!(с различен инпут, baseClass.Area() прави различни неща)

            //Със Polymorphism (с различен инпут, baseClass.Area() прави различни неща)
            //Дженериците са перфектен Polymorphism

            //Използвайки полиморфизъм можем много лесно да екстендваме програмата си!
            //Мощтта на полиморфизма и ООП-то е когато искаме да направим по сложна, да екстендваме програмата си! Например: Правим си нов клас dog, наследяваме Animal и той вече си работи с Human - a, вече Human - a може да храни кучета, той работи абстрактно!

            //abstract метод може да има само в абстракт клас и няма имплементация. Виртуал метода е във нормален(неабстрактен клас) и има имплементаця. После и двата метода се оверрайдват в класовете наследници!   

            //ключовата дума is проверява типа на обекта, демо в IsKeyword и в Animals!
            // С is можем да проверяваме и дали променлива или израз са равни на константа. Пример: if(i is max) break; , но няма голям смисъл, тъй като обикновенно си слагаме = !!!!!!!!

            //Ако ни се наложи много да използваме is (да проверяваме кой кой е) това заначи че нещо кода ни не е добе, това не е добър полиморфиъм! Може да ни се струва че това ни решава проблемите, но не е така, това ни прави проблемите! Това се прави така в кайни случаи - когто тестваме нещо или ако другите го правт така - в общи лини това се счита за лоша практика (проверките кой кой е в Animals за IsKeyword) - така губим целия полиморфизъм!

            //if (typeof(Snake) == snake.GetType()) това прави същото като is, но с is  е по лесно! snake.GetType() е рефлекшън! 
            //{
            //    Console.WriteLine("Stana");
            //}

            //Ако ни трябва мякой конкретен метод можем да кастнем.
            // as е ключова думичка за кастване
            // В Program показваме как с помощта на Is можем да кастнем shape към Rectangle!
            //Можем да вземем пропъртитата на конкретен обект като го кастнем! Пример за кастване:

            //((Snake)Pet)
            //(Pet as Snake)
            //Разликата между двата вида кастване е че при кастването с as ако не успее да кастне ще върне null, а другото гърми!!!!! Затова с as се използва по-често (с проверка за null).

            //кастването е добре да се ползва единично, да не се получава каскада (поредица) от каствания! Ще учим Солид принципите, които ни казват да не правим тайп чек!

            // Има 2 типа Polymorphism, единия е Runtime(DynamicPolymorphism), но най-често се нарича просто Polymorphism (и до сега за него говорихме, по често срещан е! Питат ли ни за Polymorphism почти винаги ни питат за Runtime Polymorphism).
            //Другия вид Polymorphism е Compile time (Static Polymorphism), а това като същност си е overload на методи (значи с virtual разрешаваме този Compile time Polymorphism)!!!
            //При overload на методи вече сме използвали Compile time Polymorphism.
            //За да оверрайднем метод, той трябва да е virtual в base класа или  да е абстракт (от абстракт клас). Прайвет и статични методи не може да се оверрайдват.
            //Virtual members use base keyword to call the base class. Оверрайдванети си върви надолу по веригата на наследяване, но ако искаме да го стрем можем със sealed!
            // При Compile time (Static Polymorphism) методите се overload - ват, а при Runtime(DynamicPolymorphism) се override -ват !!!

            //Скалиране е когато продрамата ти работи добре с 1000 потребители, но се налага да започне да работи с 3000, 20 000, 100 000 и това е много дълбока и обширна тема

            //Polymorphism - а работи абсолютно по същия начин и със интерфейси (не е само за наследяване)

            //Винаги гледаме как да не повтаряме код, това е закон!!!

            //Да не правим virtual конструктори, на лекцията за Solid ще разберем защо!

            //Ако един клас имплементира интерфейс, а друг го наследи, то той не трябва да имплементира интерфейса, автоматично го наследява и него.

            //кеyValuePair е клас който има само кеy и Value.

            //за да използваме добре полиморфизма трвбва да използваме по базови интерфейси като IEnumerable - позволява ни да имаме повече колекции вътре (съдържа List, Dictionary, Stack, Queue). Да свикваме да използваме най-базовите класове за постигане на добър полиморфизъм.

            //Препоръчва мастер класа С# за мултитрейдинг, много на дълбоко се влиза за полиморфизма!

            Shape shape = new Rectangle();
            if (shape is Rectangle)
            {
                Rectangle rectangle = (Rectangle)shape;
                ((Rectangle)shape).//така можем да кастнем shape към Rectangle и като сложим точката ще имаме пропъртитата и методите на Rectangле -а !
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
