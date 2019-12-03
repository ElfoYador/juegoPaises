using System;
using System.Collections.Generic;

namespace LibreriasJuego
{
    public interface IPregunta
    {
        public IPartida partida { get; }
        public IPais pais { get; }
        public bool proponerRespuesta(string capitalSugerida);
        public bool acierto { get; }
        public int intentosRestantes { get; }

        public IList<string> RespuestasPropuestas { get; }
    }
}