using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Task_3_Vasylchenko.Chokolad
{
    public class ChocolateFromSugar : ChocolateCandy
    {
        public ChocolateFromSugar(string name, double price, double weight, TypesOfChokolate typeChokolad, double amountOfSugar)
           : base(name, price, weight, typeChokolad)
        {
            AmountOfSugar = amountOfSugar;
        }

        public double AmountOfSugar { get; set; }
    }
}
