using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprel19.Models
{
    internal class Wolf: Animal
    {
        public bool IsPrideLeader { get; set; }
        public int AttackDamage { get; set; }
        public Wolf(bool isPrideLeader, int attackDamage):base(5, "gv",8)
        {
            IsPrideLeader = isPrideLeader;
            AttackDamage = attackDamage;
        }
        public override void Hunt<T>(T animal)
        {
            animal.HP -= AttackDamage;
        }
    }
}
