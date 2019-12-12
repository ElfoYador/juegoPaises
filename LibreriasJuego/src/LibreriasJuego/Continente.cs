using System.Collections.Generic;

namespace LibreriasJuego
{
    public class Continente: IContinente
    {

        public Continente(string nombre) {
            this.nombre = nombre;
            misPaises = new Dictionary<string, IPais>();
        }
        public string nombre { get; }

        private Dictionary <string,IPais> misPaises { get; }
       public IList<IPais> paises { get => new List<IPais> (misPaises.Values).AsReadOnly(); }
                       

        public IPais getPais(string nombrePais) {

            return misPaises[nombrePais];
        }
        public void asignarPais (IPais nuevoPais)
        {
            misPaises.Add(nuevoPais.nombre, nuevoPais);
        }
    }
}