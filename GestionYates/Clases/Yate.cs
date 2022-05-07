using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionYates.Clases
{
    public class Yate
    {

        public string Codigo { get; set; }
		public string Descripcion { get; set; }
		public string Estado { get; set; }
		public string Foto { get; set; }

        public int Precio { get; set; }

     
        public Yate()
        {
        }

        public Yate(string codigo, string descripcion, string estado, string foto, int precio)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Estado = estado;
            Foto = foto;
            Precio = precio;
        }
    }
}
