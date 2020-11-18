using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Cat : Animal
    {
        public Cat(string name, string favoriteFood) 
            : base(name, favoriteFood)//подаваме ги на базовия конструктор защото ние тука не ги ползваме, в класа Cat не използваме нито name нито favoriteFood. Тъй като се ползват в Animal не ги сейваме тук, а директно ги подаваме на базовия клас Animal.
        { }

        public override string ExplainSelf()
        {
            return base.ExplainSelf() + "\n" + "MEEOW";
        }
    }
}
