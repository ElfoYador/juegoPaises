using LibreriasJuego;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PruebasLibreria
{
    [TestClass]
    public class PruebasPreguntas
    {
        [TestMethod]
        public void TestNuevaPregunta()
        {
            IBaseDatosJugadores miBaseDatosJugadores =
                Juego.GetInstancia().baseDatosJugadores;
            IJugador ivan = miBaseDatosJugadores.getOrCreateJugador("Ivan");
            IContinente europa = Juego.GetInstancia().baseDatosGeografica.getContinente("Europa");
            IPartida partida = ivan.getNuevaPartida(europa);
            IPregunta pregunta = partida.nuevaPregunta();
            Assert.IsNotNull(pregunta);
            Assert.IsNotNull(pregunta.pais);
        }
        [TestMethod]
        public void TestRespuestaFallida()
        {
            IBaseDatosJugadores miBaseDatosJugadores =
                Juego.GetInstancia().baseDatosJugadores;
            IJugador ivan = miBaseDatosJugadores.getOrCreateJugador("Ivan");
            IContinente europa = Juego.GetInstancia().baseDatosGeografica.getContinente("Europa");
            IPartida partida = ivan.getNuevaPartida(europa);
            IPregunta pregunta = partida.nuevaPregunta();
            bool resultado = pregunta.proponerRespuesta("Ruina");
            Assert.IsFalse(resultado);
        }
        [TestMethod]
        public void TestRespuestasFallidasMultiples()
        {
            IBaseDatosJugadores miBaseDatosJugadores =
                Juego.GetInstancia().baseDatosJugadores;
            IJugador ivan = miBaseDatosJugadores.getOrCreateJugador("Ivan");
            IContinente europa = Juego.GetInstancia().baseDatosGeografica.getContinente("Europa");
            IPartida partida = ivan.getNuevaPartida(europa);
            IPregunta pregunta = partida.nuevaPregunta();
            int intentos = pregunta.intentosRestantes;
            Assert.AreEqual(intentos,3);

            pregunta.proponerRespuesta("Ruina");
            pregunta.proponerRespuesta("Ruina");
            pregunta.proponerRespuesta("Ruina");

            intentos = pregunta.intentosRestantes;
            Assert.AreEqual(intentos, 0);

//            pregunta.proponerRespuesta("Ruina");


        }


        [TestMethod]
        public void TestRespuestaCorrecta()
        {
            IBaseDatosJugadores miBaseDatosJugadores =
                Juego.GetInstancia().baseDatosJugadores;
            IJugador ivan = miBaseDatosJugadores.getOrCreateJugador("Ivan");
            IContinente europa = Juego.GetInstancia().baseDatosGeografica.getContinente("Europa");
            IPartida partida = ivan.getNuevaPartida(europa);
            IPregunta pregunta = partida.nuevaPregunta();
            bool resultado = pregunta.proponerRespuesta(pregunta.pais.capital);
            Assert.IsTrue(resultado);
        }
    }
}
