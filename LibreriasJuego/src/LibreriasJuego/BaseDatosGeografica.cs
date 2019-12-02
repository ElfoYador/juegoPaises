using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public interface BaseDatosGeografica
    {
        

        public Jugador getContinente(string nombreContinente);

      

        public IList<Continente> getContinentes();
    }
}
