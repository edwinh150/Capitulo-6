using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1Cap6
{
    class Cap6E5
    {
        public static void Burbuja(int[] vector)
        {
            int auxiliar;

            for (int i = vector.Length - 1; i > 0; i--)
            {

                for (int j = 0; j < i; j++)
                {

                    if (vector[j] < vector[j + 1])
                    {
                        auxiliar = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = auxiliar;
                    }
                }
            }

        }

        public void MostrarJagged()
        {
            int[][] Ordenacion = new int[4][];
            Ordenacion[0] = new int[4] { 7, 3, 5, 4 };
            Ordenacion[1] = new int[3] { 6, 12, 8 };
            Ordenacion[2] = new int[3] { 10, 9 ,11 };
            Ordenacion[3] = new int[3] { 1, 0, 2 };

            Burbuja(Ordenacion[0]);
            Burbuja(Ordenacion[1]);
            Burbuja(Ordenacion[2]);
            Burbuja(Ordenacion[3]);

            for (int x = 0; x < Ordenacion.Length; x++)
            {
                System.Console.WriteLine("Arreglo Jagged: {0}", x);
                for (int y = 0; y < Ordenacion[x].Length; y++)
                {
                    System.Console.WriteLine("{0}", Ordenacion[x][y]);
                }
            }
            System.Console.ReadKey();
        }
    }
}
