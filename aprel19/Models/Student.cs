using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprel19.Models
{
    internal class Student
    {
        public string Name { get; set; }
        public bool IsPlagiated { get; set; }
        public bool IsHelpedToPlagiate { get; set; }
        public Student(string name, bool isPlagiated, bool isHelpedToPlagiate)
        {
            Name = name;
            IsPlagiated = isPlagiated;
            IsHelpedToPlagiate = isHelpedToPlagiate;
        }
    }
}
