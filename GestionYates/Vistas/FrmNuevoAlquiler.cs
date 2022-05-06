﻿using System;
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
    public partial class FrmNuevoAlquiler : Form
    {
        public FrmNuevoAlquiler()
        {
            InitializeComponent();
            cargarDatos();
        }

        public void cargarDatos()
        {
            string[] clientes = new [] { "Naviera SA", "Kili", "Naviera Ibiza", "Naviera Bilbao", "Barcos Sagunto", "Recreativos Ferrol", "Santander", "Vigo Inc.", "Ferrol Barcos" };
            lstClientes.DataSource = clientes;
        }


    }
}
