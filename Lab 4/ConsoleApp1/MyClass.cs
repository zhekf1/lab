using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyClass
    {
        private int a = -16;
        private int b = -9;

        public int C()
        {
            return Math.Abs(a + b);
        }

        public int A
        {
            get { return a; }
        }

        public int B
        {
            get { return b; }
        }
    }
}
