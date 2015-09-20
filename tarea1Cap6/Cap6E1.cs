using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1Cap6
{
    class Cap6E1
    {
        public void Promedio()
        {
            double[][] Promedio = new double[3][];
            double res = 0;

            Promedio[0] = new double[4];
            Promedio[1] = new double[2];
            Promedio[2] = new double[2];

            Console.WriteLine("Digite 8 Numeros:");

            for (int x = 0; x < Promedio.Length; x++)
            {
                for (int y = 0; y < Promedio[x].Length; y++)
                {
                    Promedio[x][y] = Double.Parse(Console.ReadLine());
                }
            }


            for (int i = 0; i < Promedio.Length; i++)
            {
                for (int j = 0; j < Promedio[i].Length; j++)
                {
                    res += Promedio[i][j];
                }
                Console.WriteLine();
            }

            Console.WriteLine("{0}", res / 8);
            Console.ReadKey();
        }
    }
}
