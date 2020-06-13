using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    class A
    {
        protected int a;
        protected int b;

        public A()
        {
            a = 1;
            b = 1;
        }
        public A(int A, int B)
        {
            a = A;
            b = B;
        }

        public int A1
        {
            get { return a; }
            set { a = value; }
        }

        public int B
        {
            get { return b; }
            set { b = value; }
        }

        public void output()
        {
            Console.WriteLine("a = " + a + ", b = " + b);
        }
    }
}
