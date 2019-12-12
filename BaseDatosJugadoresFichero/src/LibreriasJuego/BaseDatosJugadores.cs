using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public class BaseDatosJugadores : IBaseDatosJugadores

    {
       
        public BaseDatosJugadores()
        {
            misJugadores = new Dictionary<string, IJugador>();
        }
        private Dictionary<string, IJugador> misJugadores { get; }

        public IJugador nuevoJugador(string nombreJugador) {
            IJugador j = new Jugador(nombreJugador);
            misJugadores.Add(nombreJugador,j);
            return j;

        }

        public IJugador getJugador(string nombreJugador)
        {
            return misJugadores[nombreJugador];

        }

        public IJugador getOrCreateJugador(string nombreJugador) { 
              if (misJugadores.ContainsKey(nombreJugador)) 
                return getJugador(nombreJugador);
            return nuevoJugador(nombreJugador);
        }

        public IList<IJugador> jugadores { get => new List<IJugador>(misJugadores.Values).AsReadOnly(); }
    }
}
