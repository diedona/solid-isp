using DDona.Solid.ISP.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Solid.ISP.Model
{
    public class NPC : ICanTalk
    {
        public string Talk()
        {
            return "NPC text";
        }
    }
}
