using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea1Cap6
{
    public partial class Cap6e2Form : Form
    {
        int Curso;
        int Estudiantes;
        int Calificaciones;
        int pos;

        ArrayList MenorCalificaciones;

        public Cap6e2Form()
        {
            InitializeComponent();
            MenorCalificaciones = new ArrayList();
        }

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

        private void CrearMbutton_Click(object sender, EventArgs e)
        {
            Curso = Convert.ToInt32(SalonestextBox.Text);
            Estudiantes = Convert.ToInt32(AlumnostextBox.Text);

            int[][] Menor = new int[Curso][];


            for (int x = 0; x < Curso; x++)
            {
                Menor[x] = new int[Estudiantes];
            }

            CrearMbutton.Text = "Mostrar";
            ResultadolistBox.Items.Add("Agregar los datos: ");
            if (Calificaciones > 0)
            {

                for (int y = 0; y < Curso; y++)
                {
                    for (int i = 0; i < Menor[y].Length; i++)
                    {
                        Calificaciones = Menor[i][y] = Int32.Parse(MenorCalificaciones[pos++].ToString());//guardando lo que capturo el arraylis psandolo a Jagged.
                    }

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
                    ResultadolistBox.Items.Add("La menor calificacion es: ");
                    ResultadolistBox.Items.Add(Menor[x][0]);//mostrandola en el listbox
                }
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Calificaciones = Convert.ToInt32(CaltextBox.Text);
            ResultadolistBox.Items.Add(Calificaciones);
            MenorCalificaciones.Add(Calificaciones);
            MessageBox.Show("Guardada.");
            CaltextBox.Text = "";
        }
    }
}
