using System.Collections.Generic;

namespace LibreriasJuego
{
    public interface Continente
    {
        public string nombre { get; }
       public IList<Pais> paises { get; }

        public Pais getPais(string nombrePais);
    }
}