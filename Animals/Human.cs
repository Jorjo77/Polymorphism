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
            Pet.Eat("Qj de");
        }
        public void PutToSleap()
        {
            Pet.Sleep();
        }
    }
}
