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
            IBaseDatosJugadores miBaseDatosJugadores =
                Juego.GetInstancia().baseDatosJugadores;
            IJugador ivan = miBaseDatosJugadores.getOrCreateJugador("Ivan");
            Assert.IsNotNull(ivan.historicoPartidas);
        }
        [TestMethod]
        public void TestNuevaPartida1()
        {
            IBaseDatosJugadores miBaseDatosJugadores =
                Juego.GetInstancia().baseDatosJugadores;
            IJugador ivan = miBaseDatosJugadores.getOrCreateJugador("Ivan");
            IContinente europa = Juego.GetInstancia().baseDatosGeografica.getContinente("Europa");
            IPartida partida = ivan.getNuevaPartida(europa);
            Assert.IsNotNull(partida);
        }
        [TestMethod]
        public void TestNuevaPartida2()
        {
            IBaseDatosJugadores miBaseDatosJugadores =
                Juego.GetInstancia().baseDatosJugadores;
            IJugador ivan = miBaseDatosJugadores.getOrCreateJugador("Ivan");

            int cuantasLlevaba = ivan.historicoPartidas.Count;

            IContinente europa = Juego.GetInstancia().baseDatosGeografica.getContinente("Europa");
            IPartida partida = ivan.getNuevaPartida(europa);
            
            int cuantasLleva = ivan.historicoPartidas.Count;

            Assert.AreEqual(cuantasLlevaba+1,cuantasLleva);
            Assert.AreEqual(ivan.historicoPartidas[ivan.historicoPartidas.Count - 1], partida);
        }
    }
}
