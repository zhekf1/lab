using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z4
{
    class CompareManufacturer : IComparer<Product>
    {
        public int Compare(Product a, Product b)
        {
            return a.Manufacturer.CompareTo(b.Manufacturer);
        }
    }
}
