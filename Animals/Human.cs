using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Human
    {
        public Human(Animal pet)
        {
            Pet = pet;
        }

        public Animal Pet { get; set; }

        public void Feed()
        {
            if (Pet is Snake)//примера за кастване:
            {

                Snake snake = Pet as Snake;
            }

            Pet.Eat("Qj de");
        }
        public void PutToSleap()
        {
            Pet.Sleep();
        }
    }
}
