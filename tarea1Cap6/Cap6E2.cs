﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea1Cap6
{

    class Cap6E2
    {

        public static void Burbuja(int[] vector)
        {
            int auxiliar;

            for (int i = vector.Length - 1; i > 0; i--)
            {

                for (int j = 0; j < i; j++)
                {

                    if (vector[j] > vector[j + 1])
                    {
                        auxiliar = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = auxiliar;
                    }
                }
            }

        }

        public void MenorNotas()
        {
            int Curso = 0;
            int Estudiantes = 0;
            int Notas;


            Console.WriteLine("Ingrese la Cantidad de Cursos: ");
            Curso = Int32.Parse(Console.ReadLine());

            int[][] Menor = new int[Curso][];


            for (int x = 0; x < Curso; x++)
            {
                Console.WriteLine("Digite la cantidad de Estudiantes por Cursos: {0}", x);
                Estudiantes = Int32.Parse(Console.ReadLine());

                Menor[x] = new int[Estudiantes];
            }

            for (int y = 0; y < Curso; y++)
            {
                Console.WriteLine("Curos: {0}", y);
                for (int i = 0; i < Menor[y].Length; i++)
                {
                    Console.Write("Digite las Notas: ");
                    Notas = Int32.Parse(Console.ReadLine());
                    Menor[y][i] = Notas;
                }
            }

            for (int i = 0; i < Curso; i++)
            {
                Burbuja(Menor[i]);
            }

            for (int x = 0; x < Curso - 1; x++)
            {
                if (Menor[x][0] < Menor[x + 1][0])
                {
                    System.Console.WriteLine("La Menor Nota es: {0}", Menor[x][0]);
                }
            }
            System.Console.ReadKey();
        }

    }
}