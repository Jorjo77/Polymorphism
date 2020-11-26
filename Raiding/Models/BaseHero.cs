using Raiding.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public abstract class BaseHero : IHero
    {
        protected BaseHero(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
        public virtual int Power { get;  protected set; }
        public virtual string CastAbility()
            => $"{this.GetType().Name} - {Name} ";
    }
}
