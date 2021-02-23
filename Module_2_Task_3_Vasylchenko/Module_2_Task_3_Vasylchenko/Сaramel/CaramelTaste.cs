using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Task_3_Vasylchenko.Сaramel
{
    public class CaramelTaste : CaramelCandy
    {
        public CaramelTaste(string name, double price, double weight, TypeCaramel typeCaramel, TasteCaramel tasteCaramel)
           : base(name, price, weight, typeCaramel)
        {
            TasteCaramel = tasteCaramel;
        }

        public TasteCaramel TasteCaramel { get; set; }
    }
}
