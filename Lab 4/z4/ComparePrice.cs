using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z4
{
    class ComparePrice : IComparer<Product>
    {
        public int Compare(Product a, Product b)
        {
            return a.Price.CompareTo(b.Price);
        }
    }
}
