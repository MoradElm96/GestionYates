using GestionYates.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionYates.Vistas
{
    public partial class FrmAlquileres : Form
    {
        public FrmAlquileres()
        {
            InitializeComponent();
            cargarDatos();
        }


        List<Alquiler> ListaAlquileres = new List<Alquiler>();


        public void cargarDatos()
        {
            ListaAlquileres = Controladores.ControladorAlquileres.recuperarAlquileres();
            dataGridView1.DataSource = ListaAlquileres;


        }

        private void FrmAlquileres_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void btnVerDatosYate_Click(object sender, EventArgs e)
        {

        }


       


        private void txtPuerto_TextChanged(object sender, EventArgs e)

        {
            List<Alquiler> ListaFiltrada = ListaAlquileres.FindAll(alquiler => alquiler.puerto.ToLower().Contains(txtPuerto.Text));
            dataGridView1.DataSource = ListaFiltrada;


        }

        private void btnAlquilerMasLargo_Click(object sender, EventArgs e)
        {
            //alquiler mas largo

            if (Controladores.ControladorAlquileres.recuperarAlquileres().Count == 0) // si no hay alquileres
            {
                MessageBox.Show("No hay alquileres");
            }
            else
            {
                //hacer logica en el controlador
                Alquiler alquiler = Controladores.ControladorAlquileres.recuperarAlquilerMAsLargo();

                Yate yate = Controladores.ControladorYates.recuperarYate(alquiler.yate);
                MessageBox.Show("El alquiler más largo es el del yate " + yate.Descripcion + " al cliente " + alquiler.cliente + " con dias " + alquiler.numDias);
            }




        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
