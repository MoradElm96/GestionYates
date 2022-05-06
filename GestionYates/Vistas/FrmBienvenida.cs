using GestionYates.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionYates
{
    public partial class FrmBienvenida : Form
    {
        public FrmBienvenida()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            FrmAterrizaje frmAterrizaje = new FrmAterrizaje();
            frmAterrizaje.Show();
            Close();

            /*FrmBIenvenida debe mostrarse al abrir la aplicación.
             * Al pulsar “ACEPTAR” deberá abrir FrmAterrizaje y cerrarse. 
             * Si se pulsa “CERRAR” se debe terminar la aplicación.*/



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
