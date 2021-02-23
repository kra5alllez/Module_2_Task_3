using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Task_3_Vasylchenko.Chokolad
{
    public class ChocolateCandy : Sweetnes
    {
        public ChocolateCandy(string name, double price, double weight, TypesOfChokolate typeChokolad)
           : base(name, price, weight)
        {
            TypeChokolad = typeChokolad;
        }

        public TypesOfChokolate TypeChokolad { get; set; }
    }
}
