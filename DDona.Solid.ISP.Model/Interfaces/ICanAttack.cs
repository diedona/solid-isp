using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Solid.ISP.Model.Interfaces
{
    public interface ICanAttack : IPlayer
    {
        int Strength { get; set; }
        int Dexterity { get; set; }
        IAttack BasicAttack { get; set; }

        IAttack DoAttack();
    }
}
