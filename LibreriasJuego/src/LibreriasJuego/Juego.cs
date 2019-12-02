using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
   public class Juego
    {

        private static Juego miJuego;
        private Juego() { 
           
        }

        public static Juego GetInstancia()
        {
            if (miJuego == null)
            {
                miJuego = new Juego();
            }
            return miJuego;
        }
    }
}
