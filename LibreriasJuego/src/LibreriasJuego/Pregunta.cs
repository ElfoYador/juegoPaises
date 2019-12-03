using System;
using System.Collections.Generic;

namespace LibreriasJuego
{
    public class Pregunta: IPregunta
    {
        
        internal Pregunta (IPartida partida,IPais pais)
        {
            this.partida = partida;
            this.pais = pais;
            intentosRestantes = 3;
            RespuestasPropuestas = new List<string>();
            acierto = false;

        }
        public IPartida partida { get; }
        public IPais pais { get; }
        public bool proponerRespuesta(string capitalSugerida) {
            if (intentosRestantes == 0)
            {
                throw new Exception("Ruinera... no quedan intentos");
            }
            RespuestasPropuestas.Add(capitalSugerida);
            this.intentosRestantes--;
            acierto = (capitalSugerida == this.pais.capital);
            return acierto;
        }
        public bool acierto { get; private set; }
        public int intentosRestantes { get; private set; }


        public IList<string> RespuestasPropuestas { get; }
    }
}