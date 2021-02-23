using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Task_3_Vasylchenko
{
    public class Sweetnes : IComparable<Sweetnes>
    {
        public Sweetnes(string name, double price, double weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }
        public int CompareTo(Sweetnes sweetnes)
        {
            return Weight.CompareTo(sweetnes.Weight);
        }
    }
}
