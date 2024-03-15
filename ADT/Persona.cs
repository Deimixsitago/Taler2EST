using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2.ADT
{
    internal class Persona
    {
        private int id;
        private double x, y;
        private Estacion estacionAsociada;

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

        public Estacion EstacionAsociada
        {
            get { return estacionAsociada; }
            set { estacionAsociada = value; }
        }

        public Persona(int id, double x, double y)
        {
            this.id = id;
            this.x = x;
            this.y = y;
            this.estacionAsociada = null; // Inicialmente nula
        }
    }
    
}
