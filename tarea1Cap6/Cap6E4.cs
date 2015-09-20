using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1Cap6
{
    class Cap6E4
    {
        int cantidad = 0;
        int salones = 0;
        int n = 0;
        int m = 0;
        string valor = "";

        public void Salones()
        {
            Console.WriteLine("Dame la cantidad de salones");
            valor = Console.ReadLine();
            salones = Convert.ToInt32(valor);
        }

        public void Alumno()
        {
            Salones();

            float[][] calif = new float[salones][];

            for (n = 0; n < salones; n++)
            {
                Console.WriteLine("Dame la cantidad de alumnos para el salon {0}", n);
                valor = Console.ReadLine();
                cantidad = Convert.ToInt32(valor);
                calif[n] = new float[cantidad];
            }

            for (n = 0; n < salones; n++)
            {
                Console.WriteLine("Salon {0}", n);
                for (m = 0; m < calif[n].GetLength(0); m++)
                {
                    Console.Write("Dame la calificación ");
                    valor = Console.ReadLine();
                    calif[n][m] = Convert.ToSingle(valor);
                }
            }

            Console.WriteLine("—— Información ——");
            for (n = 0; n < salones; n++)
            {
                Console.WriteLine("Salon {0}", n);
                for (m = 0; m < calif[n].GetLength(0); m++)
                {
                    Console.WriteLine("El alumno {0} tiene {1} ", m, calif[n][m]);
                }
            }
            Console.ReadKey();
        }
    }
}
