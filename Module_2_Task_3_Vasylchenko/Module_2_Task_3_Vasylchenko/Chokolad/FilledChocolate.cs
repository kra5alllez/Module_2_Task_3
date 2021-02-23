using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Task_3_Vasylchenko.Chokolad
{
    public class FilledChocolate : ChocolateFromSugar
    {
        public FilledChocolate(string name, double price, double weight, TypesOfChokolate typeChokolad, double amountOfSugar, TypeFilling typeFilling)
           : base(name, price, weight, typeChokolad, amountOfSugar)
        {
            TypeFilling = typeFilling;
        }

        public TypeFilling TypeFilling { get; set; }
    }
}
