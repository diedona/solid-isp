using DDona.Solid.ISP.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Solid.ISP.Model
{
    public class Punch : IAttack
    {
        public int BaseDamagePoints { get; set; }
        public ICanAttack Owner { get; set; }

        public double CalculateTotalDamage()
        {
            return (this.BaseDamagePoints + (this.Owner.Strength * 1.5) + (this.Owner.Dexterity * 0.5));
        }
    }
}
