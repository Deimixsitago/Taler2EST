using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.ADT
{
    internal class Estacion
    {
        private int id;
        private double x, y;

        public int Id
        {
            get { return id; }
        }

        public double X
        {
            get { return x; }
        }

        public double Y
        {
            get { return y; }
        }

        public Estacion(int id, double x, double y)
        {
            this.id = id;
            this.x = x;
            this.y = y;
        }
    }
}
