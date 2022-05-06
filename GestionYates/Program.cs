using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionYates
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //ojo aqui, instanciar el formulario fuera del run
            FrmBienvenida frmBienvenida = new FrmBienvenida();
            frmBienvenida.Show();

            Application.Run();



        }
    }
}
