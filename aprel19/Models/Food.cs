﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aprel19.Models
{
    internal abstract class Food
    {

        public int Calorie { get; set; }
        public Food(int calorie) 
        {
            Calorie = calorie;
        }
    }
}
