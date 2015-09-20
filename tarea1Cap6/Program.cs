using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace tarea1Cap6
{
    class Program
    {
        static void Main(string[] args)
        {
            Cap6E1 e = new Cap6E1();
            Cap6E2 e2 = new Cap6E2();
            Cap6E3 e3 = new Cap6E3();
            Cap6E4 e4 = new Cap6E4();
            Cap6E5 e5 = new Cap6E5();

            int menu;

            do
            {
                Console.Clear();
                Console.WriteLine("MENU");
                Console.WriteLine("Eliga una opcion :");
                Console.WriteLine("1 . Ejercicio 1");
                Console.WriteLine("2 . Ejercicio 2");
                Console.WriteLine("3 . Ejercicio 3");
                Console.WriteLine("4 . Ejercicio 4");
                Console.WriteLine("5 . Ejercicio 5");
                Console.WriteLine("para salir eliga la opcion 0 :");

                menu = Int32.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        e.Promedio();
                        break;
                    case 2:
                        e2.MenorNotas();
                        break;
                    case 3:
                        e3.MayorNotas();
                        break;
                    case 4:
                        e4.Alumno();
                        break;
                    case 5:
                        e5.MostrarJagged();
                        break;
                }

            } while (menu != 0);
        }
    }
}
