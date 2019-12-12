using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
   public abstract class IJuego<T> where T:IJuego<T>
    {

        private static IJuego<T> instancia;
        private static readonly object testigo = new object();
        //  En java, para trabajar con concurrencia, las variable testigo debe tener en la definición el modificador volátil(para que no la cachee)
        public IBaseDatosJugadores baseDatosJugadores { get; protected set; }
        public IBaseDatosGeografica baseDatosGeografica { get; protected set; }

        // En java este método del singleton debe tener el modificador synchronized en vez del lock
        public static IJuego<T> GetInstancia()
        {
            if (instancia == null)
            {
                lock (testigo)
                if (instancia == null)
                {
                    instancia = Activator.CreateInstance(typeof(T),true) as T;
                }
            }
            return instancia;
        }


      
    }
}
