using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public interface IBaseDatosGeografica
    {
        

        public IContinente getContinente(string nombreContinente);

        public IPais getPais(string nombrePais);



        public IList<IContinente> Continentes { get; }
    }
}
