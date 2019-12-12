using System;
using System.Collections.Generic;

namespace LibreriasJuego
{
    public class Jugador:IJugador

    {
        public Jugador(string nombre) {
            this.nombre = nombre;
            historicoPartidas = new List<IPartida>();

        
        }
        public string nombre { get; }
        public IList<IPartida> historicoPartidas { get; }
        public IPartida getNuevaPartida(IContinente continente)
        {
            Partida p = new Partida(this, continente);
            historicoPartidas.Add(p);
            return p;

        }

    }
}
