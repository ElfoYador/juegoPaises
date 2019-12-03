using System;
using System.Collections.Generic;

namespace LibreriasJuego
{
    public interface IJugador
    {
        public string nombre { get; }
        public IList<IPartida> historicoPartidas { get; }
        public IPartida getNuevaPartida(IContinente continente);

    }
}
