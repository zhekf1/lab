using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    class DemoPoint: IDemo
    {
        protected int x;
        protected int y;

        public DemoPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Show()
        {
            Console.WriteLine("Точка на плоскости: ({0}, {1})", x, y);
        }

        public double Dlina()
        {
            return Math.Sqrt(x * x + y * y);
        }

        public int X
        {
            get
            {
                return x;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
        }

        public int this[int i]
        {
            get
            {
                if (i == 0) return x;
                else if (i == 1) return y;
                else throw new Exception("Недопустимое значение индекса");
            }
            set
            {
                if (i == 0) x = value;
                else if (i == 1) y = value;
                else throw new Exception("Недопустимое значение индекса");
            }
        }
    }
}
