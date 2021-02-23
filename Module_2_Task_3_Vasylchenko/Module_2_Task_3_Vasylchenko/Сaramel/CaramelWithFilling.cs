using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Task_3_Vasylchenko.Сaramel
{
    public class CaramelWithFilling : CaramelTaste
    {
        public CaramelWithFilling(string name, double price, double weight, TypeCaramel typeCaramel, TasteCaramel tasteCaramel, TypeFillinginCaramel typeFillinginCaramel)
           : base(name, price, weight, typeCaramel, tasteCaramel)
        {
            TypeFillinginCaramel = typeFillinginCaramel;
        }

        public TypeFillinginCaramel TypeFillinginCaramel { get; set; }
    }
}
