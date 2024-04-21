using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace aprel19.Models
{
    internal abstract class Animal
    {
        private Gender gender;
        public int AvgLifeTime { get; set; }
        public string Breed { get; set; }
        public int HP { get; set; }

        protected Animal(int avgLifeTime,string breed,int hP)
        {
            AvgLifeTime = avgLifeTime;
            Breed = breed;
            HP = hP;
        }

        public abstract void Hunt<T>(T animal) where T : Animal;

        enum Gender
        {
            Male,
            Female
        }
    }
}
