using LibreriasJuego;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PruebasLibreria
{
    [TestClass]
    public class PruebasPartidas
    {
        [TestMethod]
        public void TestRecuperarListaPartidas()
        {
            BaseDatosJugadores miBaseDatosJugadores =
                Juego.GetInstancia().baseDatosJugadores;
            Jugador ivan = miBaseDatosJugadores.getOrCreateJugador("Ivan");
            Assert.IsNotNull(ivan.historicoPartidas);
        }
        [TestMethod]
        public void TestNuevaPartida1()
        {
            BaseDatosJugadores miBaseDatosJugadores =
                Juego.GetInstancia().baseDatosJugadores;
            Jugador ivan = miBaseDatosJugadores.getOrCreateJugador("Ivan");
            Continente europa = Juego.GetInstancia().baseDatosGeografica.getContinente("Europa");
            Partida partida = ivan.nuevaPartida(europa);
            Assert.IsNotNull(partida);
        }
        [TestMethod]
        public void TestNuevaPartida2()
        {
            BaseDatosJugadores miBaseDatosJugadores =
                Juego.GetInstancia().baseDatosJugadores;
            Jugador ivan = miBaseDatosJugadores.getOrCreateJugador("Ivan");

            int cuantasLlevaba = ivan.historicoPartidas.Count;

            Continente europa = Juego.GetInstancia().baseDatosGeografica.getContinente("Europa");
            Partida partida = ivan.nuevaPartida(europa);
            
            int cuantasLleva = ivan.historicoPartidas.Count;

            Assert.AreEqual(cuantasLlevaba+1,cuantasLleva);
            Assert.AreEqual(ivan.historicoPartidas[ivan.historicoPartidas.Count - 1], partida);
        }
    }
}
