using GestionYates.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionYates.Vistas
{
    public partial class FrmNuevoAlquiler : Form
    {
        public FrmNuevoAlquiler()
        {
            InitializeComponent();
            cargarDatos();
        }



        public void cargarDatos()
        {
            string[] clientes = new[] { "Naviera SA", "Kili", "Naviera Ibiza", "Naviera Bilbao", "Barcos Sagunto", "Recreativos Ferrol", "Santander", "Vigo Inc.", "Ferrol Barcos" };
            lstClientes.DataSource = clientes;


            List<Yate> listaYates = Controladores.ControladorYates.recuperarYates();

            cmbYates.DataSource = listaYates.FindAll((yate) => yate.Estado == "D");//para filtrar la lista por los que tengan estado "D"
            cmbYates.DisplayMember = "Descripcion";// el nombre que se muestra en el combobox
            cmbYates.ValueMember = "Codigo";//el valor que coje si se selecciona

            monFechaRecogida.MinDate = DateTime.Now.AddDays(1);//para no seleccionar fecha anterior al dia de hoy 
            lblTarjeta.Visible = false;
            lblPuertos.Visible = false;


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string clientes = lstClientes.SelectedItem.ToString();
            string yate = cmbYates.SelectedValue.ToString();
            DateTime fechaRecogida = this.monFechaRecogida.SelectionStart.Date;//para selecionar la fecha
            string NumtarjetaPago = txtTarjeta.Text;
            string puerto = txtPuerto.Text;
            int numeroDias = (int)numericUpDown1.Value;

            bool error = false;


            Regex regexTarjeta = new Regex(@"^\d{5}[a-zA-Z]$");//para validar tarjeta


            if (Controladores.ControladorPuertos.recuperarPuertos().FindIndex(ele => ele.ToLower() == puerto.ToLower()) == -1)//si no esta
            {
                lblPuertos.Visible = true;
                error = true;



            }
            else
            {

                lblPuertos.Visible = false;

            }
            if (!regexTarjeta.IsMatch(NumtarjetaPago.ToString()))
            {

                lblTarjeta.Visible = true;
                error = true;

            }
            else
            {
                this.lblTarjeta.Visible = false;

            }
            if (!error)
            {

                List<Alquiler> listaNuevoAlquiler = new List<Alquiler>();

                Alquiler alquiler = new Alquiler(clientes, yate, puerto, fechaRecogida, numeroDias, NumtarjetaPago);

                if (
                Controladores.ControladorAlquileres.guardarAlquiler(alquiler))
                {
                    MessageBox.Show("Alquiler guardado con exito");
                    Close();
                }
                else
                {

                    MessageBox.Show("Alquiler no se ha podido guardar");
                }



            }








        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTarjeta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

