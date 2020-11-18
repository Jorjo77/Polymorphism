using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Cat : Animal
    {
        public override void Sleep()
        {
            Console.WriteLine("Never sleep"); ;
        }
    }
}
