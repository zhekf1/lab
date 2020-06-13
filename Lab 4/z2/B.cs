using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    class B: A
    {
        private int d;

        public int D
        {
            get { return d; }
            set { d = value; }
        }

        public B(int a, int b, int d) : base(a, b)
        {
            this.d = d;
        }

        public B(int d)
        {
            this.d = d;
        }

        public int C2()
        {
            if((a + b) == 0)
            {
                Console.WriteLine("Dividing is imporsible!");
                return 0;
            }
            else
            {
                return d / (a + b);
            }
        }

        public new void output()
        {
            Console.WriteLine("a = " + a + ", b = " + b + ", d = " + d);
        }
    }
}
