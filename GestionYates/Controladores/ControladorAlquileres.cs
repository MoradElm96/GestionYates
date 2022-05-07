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
    public class ControladorAlquileres
    {


        public static bool guardarAlquiler(Alquiler alquiler)
        {
            try
            {
                List<Alquiler> listaAlquileres = ControladorAlquileres.recuperarAlquileres();
                listaAlquileres.Add(alquiler);

                string archivoJson = JsonConvert.SerializeObject(listaAlquileres);
                File.WriteAllText(ConfigurationManager.AppSettings.Get("ficheroAlquileres"), archivoJson);

            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }


            public static List<Alquiler> recuperarAlquileres()
            {
                List<Alquiler> listaAlquileres = new List<Alquiler>();
                try
                {
                    string archivoJson = File.ReadAllText(ConfigurationManager.AppSettings.Get("ficheroAlquileres"));
                    //añadir ruta a mano en app setings
                    listaAlquileres = JsonConvert.DeserializeObject<List<Alquiler>>(archivoJson);
                }
                catch (Exception) { }

                return listaAlquileres;
            }



            /*public static bool eliminarAlquiler(int codigoAlquiler)
            {
                List<Alquiler> lista = recuperarAlquileres();
                int posicion = lista.FindIndex(ele => ele.Codigo == codigoAlquiler);
                if (posicion != -1)
                {
                    lista.RemoveAt(posicion);
                    return guardarAlquiler(lista);
                }
                else return false;
            }*/
        }
    }

