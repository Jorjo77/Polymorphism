using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Snake : Animal
    {
        public override void Eat(object food)
        {
            if (!(food is Program))
            {
                Console.WriteLine("I only eat your programs");
            }
        }
    }
}
