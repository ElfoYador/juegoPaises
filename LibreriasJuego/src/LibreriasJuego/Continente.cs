using System.Collections.Generic;

namespace LibreriasJuego
{
    public class Continente: IContinente
    {

        internal Continente(string nombre) {
            this.nombre = nombre;
            paises = new List<IPais>();
            misPaises = new Dictionary<string, IPais>();
        }
        public string nombre { get; }

        private Dictionary <string,IPais> misPaises { get; }
       public IList<IPais> paises { get => { return (List)misPaises; };
                       }

        public IPais getPais(string nombrePais) {

            return misPaises[nombrePais];
        }
        internal void asignarPais (IPais nuevoPais)
        {
            misPaises.Add(nuevoPais.nombre, nuevoPais);
        }
    }
}