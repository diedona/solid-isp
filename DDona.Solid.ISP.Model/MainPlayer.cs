using DDona.Solid.ISP.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDona.Solid.ISP.Model
{
    public class MainPlayer : BasePlayer, ICanAttack, ICanDefend
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int DefenseQuality { get; set; }
        public IAttack BasicAttack { get; set; }

        public MainPlayer(IAttack basicAttack)
        {
            this.BasicAttack = basicAttack;
            this.BasicAttack.Owner = this;
        }

        public void Defend(IAttack attack)
        {
            int damage = (attack.BaseDamagePoints - this.DefenseQuality);
            if (damage > 0)
            {
                this.HitPoints -= damage;
            }
        }

        public IAttack DoAttack()
        {
            return this.BasicAttack;
        }
    }
}
