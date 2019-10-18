using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Solid.ISP.Model.Interfaces
{
    public interface IPlayer
    {
        string Name { get; set; }
        int HitPoints { get; set; }
    }
}
