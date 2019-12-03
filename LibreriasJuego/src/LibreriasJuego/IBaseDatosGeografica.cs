using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public interface IBaseDatosGeografica
    {
        

        public IJugador getContinente(string nombreContinente);

        public IPais getPais(string nombrePais);



        public IList<IContinente> getContinentes();
    }
}
