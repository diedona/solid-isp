using DDona.Solid.ISP.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Solid.ISP.Model
{
    public abstract class BasePlayer : IPlayer, ICanTalk
    {
        public string Name { get; set; }
        public int HitPoints { get; set; }

        public string Talk()
        {
            return "Base Player talking";
        }
    }
}
