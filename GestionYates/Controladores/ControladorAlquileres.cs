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


        public static Alquiler recuperarAlquilerMAsLargo()
        {
            List<Alquiler> lista = recuperarAlquileres();
            Alquiler alquiler = new Alquiler();

          
            if (lista.Count > 0) //si hay
            {
                lista.Sort((a, b) => Convert.ToInt32(b.numDias  - a.numDias));
                alquiler = lista[0];//primer elemento de la lista, preguntar porque
            }
            return alquiler;

        }
        /*
        public static bool guardarAlquileres(List<Alquiler> listaYates)
        {
            try
            {
                using (var writer = new StreamWriter("alquileres.xml"))
                {
                    // Do this to avoid the serializer inserting default XML namespaces.
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);

                    var serializer = new XmlSerializer(listaYates.GetType());
                    serializer.Serialize(writer, listaYates, namespaces);


                    List<Alquiler> listaAlquileres = ControladorAlquileres.recuperarAlquileres();
                    listaAlquileres.Add(alquiler);

                    string archivoJson = JsonConvert.SerializeObject(listaAlquileres);
                    File.WriteAllText(ConfigurationManager.AppSettings.Get("ficheroAlquileres"), archivoJson);
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error" + e.Message);
            }
            return false;
        }
        */
        /*

        public static bool eliminarAlquileres(int codigoAlquiler)
        {
            List<Alquiler> lista = recuperarAlquileres();
            int posicion = lista.FindIndex(ele => ele.Codigo == codigoAlquiler);
            if(posicion != -1)
            {
                lista.RemoveAt(posicion);
                return guardarAlquiler(lista);


            }
            else
            {
                return false;
            }
        }

        */



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

