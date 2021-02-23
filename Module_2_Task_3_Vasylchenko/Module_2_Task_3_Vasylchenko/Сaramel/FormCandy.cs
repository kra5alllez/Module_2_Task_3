using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Task_3_Vasylchenko.Сaramel
{
    public class FormCandy : CaramelWithFilling
    {
        public FormCandy(string name, double price, double weight, TypeCaramel typeCaramel, TasteCaramel tasteCaramel, TypeFillinginCaramel typeFillinginCaramel, FormCandys formCandys)
           : base(name, price, weight, typeCaramel, tasteCaramel, typeFillinginCaramel)
        {
            FormCandys = formCandys;
        }

        public FormCandys FormCandys { get; set; }
    }
}
