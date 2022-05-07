using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionYates.Clases
{
   public  class Alquiler
    {

        public int Codigo { get; set; }
        public string cliente { get; set; }
        public string yate { get; set; }
        public string puerto { get; set; }
        public DateTime fechaRecogida { get; set; }
        public int numDias { get; set; }
        public string tarjeta { get; set; }

        public Alquiler(string cliente, string yate, string puerto, DateTime fechaRecogida, int numDias, string tarjeta)
        {
            this.cliente = cliente;
            this.yate = yate;
            this.puerto = puerto;
            this.fechaRecogida = fechaRecogida;
            this.numDias = numDias;
            this.tarjeta = tarjeta;
        }

        public Alquiler(int codigo, string cliente, string yate, string puerto, DateTime fechaRecogida, int numDias, string tarjeta)
        {
            Codigo = codigo;
            this.cliente = cliente;
            this.yate = yate;
            this.puerto = puerto;
            this.fechaRecogida = fechaRecogida;
            this.numDias = numDias;
            this.tarjeta = tarjeta;
        }

        public Alquiler()
        {
        }
    }
}
