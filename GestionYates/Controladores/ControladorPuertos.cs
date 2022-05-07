using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionYates.Controladores
{
  public  class ControladorPuertos
    {

        public static List<string> recuperarPuertos()
        {
            List<string> puertos = new List<string>() { "Valencia", "Barcelona", "Ibiza", "Bilbao", "Sagunto", "Ferrol", "Santander", "Vigo", "Ferrol" };
            return puertos;
        }
    }
}
