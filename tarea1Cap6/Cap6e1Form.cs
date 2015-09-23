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

    public partial class Cap6e1Form : Form
    {
        int Salones;
        int Alumnos;
        int Calificacione;
        int pos;
        int Mostrar;
        int Total;
        ArrayList Calificaciones;

        public Cap6e1Form()
        {
            InitializeComponent();
            Calificaciones = new ArrayList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calificacione = Convert.ToInt32(CaltextBox.Text);
            ResultadolistBox.Items.Add(Calificacione);
            Calificaciones.Add(Calificacione);
            MessageBox.Show("Guardada.");
            CaltextBox.Text = "";
        }

        private void CrearMbutton_Click(object sender, EventArgs e)
        {
            Salones = Convert.ToInt32(SalonestextBox.Text);
            Alumnos = Convert.ToInt32(AlumnostextBox.Text);

            int[][] salon = new int[Salones][];

            for (int i = 0; i < Salones; i++)
            {
                salon[i] = new int[Alumnos];
            }
            CrearMbutton.Text = "Mostrar";
            ResultadolistBox.Items.Add("Agregar los datos: ");
            if (Calificacione > 0)
            {

                for (int i = 0; i < salon.Length; i++)
                {
                    for (int x = 0; x < salon[i].Length; x++)
                    {
                        Total += salon[i][x] = Int32.Parse(Calificaciones[pos++].ToString());//guardando lo que capturo el arraylis psandolo a Jagged.
                    }
                }


                ResultadolistBox.Items.Add("Lista de Calificaciones");

                for (int i = 0; i < salon.Length; i++)
                {
                    ResultadolistBox.Items.Add("Salon " + (i + 1));
                    for (int x = 0; x < salon[i].Length; x++)
                    {
                        ResultadolistBox.Items.Add(Calificaciones[Mostrar++]);//mostrandola en el listbox
                    }
                }
                ResultadolistBox.Items.Add("El Total es: " + Total);
            }
        }
    }
}
