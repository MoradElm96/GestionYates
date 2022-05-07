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

        public void cargarDatos()
        {
            List<Alquiler> listaAlquilers = Controladores.ControladorAlquileres.recuperarAlquileres();

            dataGridView1.DataSource = listaAlquilers;


        }

        private void FrmAlquileres_Load(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void btnVerDatosYate_Click(object sender, EventArgs e)
        {

        }
    }
}
