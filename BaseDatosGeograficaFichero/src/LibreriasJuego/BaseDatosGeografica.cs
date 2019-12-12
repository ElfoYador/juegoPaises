using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;

namespace LibreriasJuego
{
    public class BaseDatosGeografica: IBaseDatosGeografica
    {

        public BaseDatosGeografica() {
            miBaseDatosGeograficaContinentes = new Dictionary<string, IContinente>();
            miBaseDatosGeograficaPaises = new Dictionary<string, IPais>();
            popularBaseDatos();
        }

        private Dictionary<string, IContinente> miBaseDatosGeograficaContinentes;
        private Dictionary<string, IPais> miBaseDatosGeograficaPaises;
        public IContinente getContinente(string nombreContinente) {
            return miBaseDatosGeograficaContinentes[nombreContinente];
        
        }

        public IPais getPais(string nombrePais)
        {
            return miBaseDatosGeograficaPaises[nombrePais];
        }

        public IList<IContinente> Continentes { get => new List<IContinente>(miBaseDatosGeograficaContinentes.Values).AsReadOnly(); }

        private void popularBaseDatos()
        {
            IList<string> nombresContinentes = new List<string>();
            nombresContinentes.Add("Africa");
            nombresContinentes.Add("America");
           // nombresContinentes.Add("Asia");
            nombresContinentes.Add("Europa");
            nombresContinentes.Add("Oceania");
            // lee ficheros
            foreach (string nombre in nombresContinentes)
            {
                // crear continente 
                Continente c = new Continente(nombre);
                miBaseDatosGeograficaContinentes.Add(nombre,c);
                // lee ficheros
                string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"continentes\" + nombre + ".txt");
                string[] lineas = File.ReadAllLines(path);
                
                foreach (string linea in lineas) {
                    IPais p = procesarLineaPais(linea, c);
                    miBaseDatosGeograficaPaises.Add(p.nombre, p);
                    c.asignarPais(p);
                }

            }

            // Crear Paises


        }

        private IPais procesarLineaPais (string linea,IContinente continente)
        {
            //Australia: Camberra - Dólar Australiano
            string[] partes = linea.Split(":");
            // string nombre = partes[0].Trim();
            // string capital = partes[1].Split("-")[0].Trim();
            string nombre = linea.Substring(0,linea.IndexOf(":")).Trim();
            string capital =  linea.Substring(linea.IndexOf(":") + 1, linea.IndexOf("-") - (linea.IndexOf(":")+1)).Trim() ;
            IPais p = new Pais(nombre, capital, continente);
            return p;

        }
    }
}
