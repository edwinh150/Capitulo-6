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
    public partial class Cap6e4Form : Form
    {
        int cantidad = 0;
        int salones = 0;
        int n = 0;
        int m = 0;
        string valor = "";
        string valorC = "";

        ArrayList Calificaciones;

        public Cap6e4Form()
        {
            InitializeComponent();
            Calificaciones = new ArrayList();
        }

        public void SalonesF()
        {
            valor = Convert.ToString(SalonestextBox.Text);
            salones = Convert.ToInt32(AlumnostextBox.Text);

        }

        private void CrearMbutton_Click(object sender, EventArgs e)
        {
            SalonesF();

            int[][] calif = new int[salones][];

            for (n = 0; n < salones; n++)
            {

                ResultadolistBox.Items.Add("Dame la cantidad de alumnos para el salon: " + n);
                ResultadolistBox.Items.Add("Anotarlo en la casilla de Cantidad");
                valorC = Cantidadlabel.Text;
                cantidad = Convert.ToInt32(valor);
                calif[n] = new int[cantidad];
            }

            for (n = 0; n<salones; n++)
            {
                ResultadolistBox.Items.Add("Dame la cantidad de alumnos para el salon: " + n);
                for (m = 0; m < calif[n].GetLength(0); m++)
                {
                    ResultadolistBox.Items.Add("Dame la calificación");
                    ResultadolistBox.Items.Add("Anotarlo en la casilla de Calificacion");
                    calif[n][m] = Convert.ToInt32(CaltextBox.Text);
                }
            }

            ResultadolistBox.Items.Add("—— Información ——");
            for (n = 0; n < salones; n++)
            {
                ResultadolistBox.Items.Add("Salon: " + n);
                for (m = 0; m < calif[n].GetLength(0); m++)
                {
                    ResultadolistBox.Items.Add("El alumno " + m + " tiene " + calif[n][m]);
                }
            }
        }

        private void CaltextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            valor = CaltextBox.Text;
            ResultadolistBox.Items.Add(Calificaciones);
            Calificaciones.Add(Calificaciones);
            MessageBox.Show("Guardada.");
            CaltextBox.Text = "";
        }
    }
}
