using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Solid.ISP.Model.Interfaces
{
    public interface IAttack
    {
        ICanAttack Owner { get; set; }
        int BaseDamagePoints { get; set; }

        double CalculateTotalDamage();
    }
}
