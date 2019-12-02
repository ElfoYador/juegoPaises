using System;
using System.Collections.Generic;

namespace LibreriasJuego
{
    public interface Jugador
    {
        public string nombre { get; }
        public IList<Partida> historicoPartidas { get; }
        public Partida getNuevaPartida(Continente continente);

    }
}
