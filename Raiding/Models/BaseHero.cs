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

        public string Name { get; }
        public abstract string CastAbility();
    }
}
