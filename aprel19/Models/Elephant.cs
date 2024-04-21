using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprel19.Models
{
    internal class Elephant: Animal
    {
        public double Weight { get; set; }
        public bool IsTrained { get; set; }

        public Elephant(double weight, bool isTrained) :base(5, "gv",8)
        {
            Weight = weight;
            IsTrained = isTrained;
        }
        public override void Hunt<T>(T animal)
        {
            throw new NotImplementedException();
        }
    }
}
