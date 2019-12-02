using System;
using System.Collections.Generic;

namespace LibreriasJuego
{
    public interface Pregunta
    {
        public Partida partida { get; }
        public Pais pais { get; }
        public bool proponerRespuesta(string capitalSugerida);
        public bool acierto { get; }
        public int intentosRestantes { get; }

        public IList<string> RespuestasPropuestas { get; }
    }
}