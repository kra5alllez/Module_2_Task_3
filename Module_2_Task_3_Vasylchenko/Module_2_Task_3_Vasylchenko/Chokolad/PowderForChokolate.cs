using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Task_3_Vasylchenko.Chokolad
{
    public class PowderForChokolate : FilledChocolate
    {
        public PowderForChokolate(string name, double price, double weight, TypesOfChokolate typeChokolad, double amountOfSugar, TypeFilling typeFilling, TypePovered typePovered)
           : base(name, price, weight, typeChokolad, amountOfSugar, typeFilling)
        {
            TypePovered = typePovered;
        }

        public TypePovered TypePovered { get; set; }
    }
}
