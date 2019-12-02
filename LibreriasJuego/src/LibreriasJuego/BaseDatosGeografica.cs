using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public interface BaseDatosGeografica
    {
        

        public Jugador getContinente(string nombreContinente);

        public Pais getPais(string nombrePais);



        public IList<Continente> getContinentes();
    }
}
