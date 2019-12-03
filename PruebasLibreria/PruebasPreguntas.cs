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
            BaseDatosJugadores miBaseDatosJugadores =
                Juego.GetInstancia().baseDatosJugadores;
            Jugador ivan = miBaseDatosJugadores.getOrCreateJugador("Ivan");
            Continente europa = Juego.GetInstancia().baseDatosGeografica.getContinente("Europa");
            Partida partida = ivan.nuevaPartida(europa);
            Pregunta pregunta = partida.nuevaPregunta();
            Assert.IsNotNull(pregunta);
            Assert.IsNotNull(pregunta.pais);
        }
        [TestMethod]
        public void TestRespuestaFallida()
        {
            BaseDatosJugadores miBaseDatosJugadores =
                Juego.GetInstancia().baseDatosJugadores;
            Jugador ivan = miBaseDatosJugadores.getOrCreateJugador("Ivan");
            Continente europa = Juego.GetInstancia().baseDatosGeografica.getContinente("Europa");
            Partida partida = ivan.nuevaPartida(europa);
            Pregunta pregunta = partida.nuevaPregunta();
            bool resultado = pregunta.proponerRespuesta("Ruina");
            Assert.IsFalse(resultado);
        }
        [TestMethod]
        public void TestRespuestasFallidasMultiples()
        {
            BaseDatosJugadores miBaseDatosJugadores =
                Juego.GetInstancia().baseDatosJugadores;
            Jugador ivan = miBaseDatosJugadores.getOrCreateJugador("Ivan");
            Continente europa = Juego.GetInstancia().baseDatosGeografica.getContinente("Europa");
            Partida partida = ivan.nuevaPartida(europa);
            Pregunta pregunta = partida.nuevaPregunta();
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
            BaseDatosJugadores miBaseDatosJugadores =
                Juego.GetInstancia().baseDatosJugadores;
            Jugador ivan = miBaseDatosJugadores.getOrCreateJugador("Ivan");
            Continente europa = Juego.GetInstancia().baseDatosGeografica.getContinente("Europa");
            Partida partida = ivan.nuevaPartida(europa);
            Pregunta pregunta = partida.nuevaPregunta();
            bool resultado = pregunta.proponerRespuesta(pregunta.pais.capital);
            Assert.IsTrue(resultado);
        }
    }
}
