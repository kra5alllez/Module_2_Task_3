using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Task_3_Vasylchenko.Сaramel
{
    public class CaramelCandy : Sweetnes
    {
        public CaramelCandy(string name, double price, double weight, TypeCaramel typeCaramel)
           : base(name, price, weight)
        {
            TypeCaramel = typeCaramel;
        }

        public TypeCaramel TypeCaramel { get; set; }
    }
}
