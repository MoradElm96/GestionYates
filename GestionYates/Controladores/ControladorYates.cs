using GestionYates.Clases;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionYates.Controladores
{
    public class ControladorYates
    {

        public static List<Yate> recuperarYates()
        {
            List<Yate> listaYates = new List<Yate>();
            try
            {
                string archivoJson = File.ReadAllText(ConfigurationManager.AppSettings.Get("ficheroYates"));
                //añadir ruta a mano en app setings
                listaYates = JsonConvert.DeserializeObject<List<Yate>>(archivoJson);
            }
            catch (Exception) { }

            return listaYates;
        }

        public static Yate recuperarYate(string codigoYate)
        {
            //encontrar el yate por codigo de yate
            List<Yate> lista = recuperarYates();
            return lista.Find(ele => ele.Codigo == codigoYate);
        }




    }
}
