using System.Diagnostics;
using Taller2.ADT;

namespace Taller2
{
    internal class Program
    {
        //Declarar variables globales
        static Random rand = new Random();
        static Estacion[] estaciones;
        static Persona[] personas;
        static int M, N;

        static void Main(string[] args)
        {
            try
            {
                string sT; //string temporal para aserciones
                Console.WriteLine("¿Cuántas personas son?");
                sT = Console.ReadLine();
                Debug.Assert(!string.IsNullOrEmpty(sT), "La variable es nula o vacía.");
                Debug.Assert(int.TryParse(sT, out N) == true, "La variable no es un número entero.");
                Console.WriteLine(N);
                Console.WriteLine("¿Cuántas estaciones son?");
                sT = Console.ReadLine();
                Debug.Assert(!string.IsNullOrEmpty(sT), "La variable es nula o vacía.");
                Debug.Assert(int.TryParse(sT, out M) == true, "La variable no es un número entero.");
                Console.WriteLine(M);

                estaciones = new Estacion[M];
                personas = new Persona[N];

                CrearEstaciones();
                CrearPersonas();

                asignarEstaciones(personas, estaciones);

                foreach (Persona persona in personas)
                {
                    Console.WriteLine("La persona " + persona.Id + "  está asociada a la estación " + persona.EstacionAsociada.Id);
                }

            }
            catch (Exception e)
            {
                throw new Exception("Ocurrió un error" + e);
            }
        }

        static void asignarEstaciones(Persona[] personas, Estacion[] estaciones)
        {
            //Declarar variables
            double distanciaMinima, distancia;
            Estacion estacionAsignada;

            foreach (Persona persona in personas)
            {
                distanciaMinima = 14.143; //Comienza en la distancia máxima posible(De una esquina a otra) en un campo de 10x10
                estacionAsignada = null;
                foreach (Estacion estacion in estaciones)
                {
                    distancia = CalcularDistancia(persona.X, persona.Y, estacion.X, estacion.Y);
                    if (distancia <= distanciaMinima)
                    {
                        distanciaMinima = distancia; //Cambia la distancia mínima
                        estacionAsignada = estacion; //Cambia la estación mas cercana
                    }
                }

                persona.EstacionAsociada = estacionAsignada;//asignar estación mas cercana
            }
        }

        static void CrearPersonas()
        {
            double x, y;

            // Crear personas
            for (int i = 0; i < N; i++)
            {
                x = rand.NextDouble() * 10; //x aleatoria entre 0 y 10
                y = rand.NextDouble() * 10; //y aleatoria entre 0 y 10
                personas[i] = new Persona(i + 1, x, y);
            }
        }
        static void CrearEstaciones()
        {
            double x, y;

            // Crear estaciones
            for (int i = 0; i < M; i++)
            {
                x = rand.NextDouble() * 10; //x aleatoria entre 0 y 10
                y = rand.NextDouble() * 10; //y aleatoria entre 0 y 10
                estaciones[i] = new Estacion(i + 1, x, y);
            }
        }

        static double CalcularDistancia(double x1, double y1, double x2, double y2)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;
            return Math.Sqrt(dx * dx + dy * dy);
        }



    }
}