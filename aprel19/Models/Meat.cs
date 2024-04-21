using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprel19.Models
{
    internal class Meat: Food
    {
        public enum MeatType { Beef, Chicken, Fish }
        public Meat(int calorie, MeatType type) : base(calorie)
        {
            Type = type;
        }

        public MeatType Type { get; set; }

    }
}
