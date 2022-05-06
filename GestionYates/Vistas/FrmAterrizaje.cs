using GestionYates.Controladores;
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
    public partial class FrmAterrizaje : Form
    {
        public FrmAterrizaje()
        {
            InitializeComponent();
        }

        private void nuevoAlquilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoAlquiler frmNuevoAlquiler;

            if (!ControladorFormularios.EstaFormularioAbierto(typeof(FrmNuevoAlquiler)))
            {
                frmNuevoAlquiler = new FrmNuevoAlquiler();
               
                frmNuevoAlquiler.WindowState = FormWindowState.Normal;

                frmNuevoAlquiler.Show();
                
            }
            else
            {
                frmNuevoAlquiler = (FrmNuevoAlquiler)ControladorFormularios.RecuperarFormulario(typeof(FrmNuevoAlquiler));
                if (frmNuevoAlquiler.WindowState == FormWindowState.Minimized)
                {
                    frmNuevoAlquiler.WindowState = FormWindowState.Maximized;//preguntar porque no maximizado
                }
                frmNuevoAlquiler.Show();
                frmNuevoAlquiler.Focus();
            }
        }

        private void alquileresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FrmAlquileres frmAlquileres = new FrmAlquileres();
            frmAlquileres.MdiParent = this;
            frmAlquileres.WindowState = FormWindowState.Maximized;
            frmAlquileres.Show();
            //acordarsed de activar en true is mdi parent 
        }

        private void alquileresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAlquileres frmAlquileres = new FrmAlquileres();
            frmAlquileres.MdiParent = this;
            frmAlquileres.WindowState = FormWindowState.Maximized;
            frmAlquileres.Show();
            //duda si el boton es este o no
        }
    }
}
