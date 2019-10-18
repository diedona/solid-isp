using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Solid.ISP.Model.Interfaces
{
    public interface ICanDefend : IPlayer
    {
        int DefenseQuality { get; set; }
        void Defend(IAttack attack);
    }
}
