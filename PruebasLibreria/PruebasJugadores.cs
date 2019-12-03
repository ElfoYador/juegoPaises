using LibreriasJuego;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PruebasLibreria
{
    [TestClass]
    public class PruebasJugadores
    {
        [TestMethod]
        public void TestAltaJugador()
        {
            BaseDatosJugadores miBaseDatosJugadores =
                Juego.GetInstancia().baseDatosJugadores;
            Jugador ivan = miBaseDatosJugadores.nuevoJugador("Ivan");
            Assert.IsNotNull(ivan);
        }
        [TestMethod]
        public void TestRecuperacionJugador()
        {
            BaseDatosJugadores miBaseDatosJugadores =
                Juego.GetInstancia().baseDatosJugadores;
            Jugador ivan = miBaseDatosJugadores.getJugador("Ivan");
            Assert.IsNotNull(ivan);
        }
        [TestMethod]
        public void TestAltaYRecuperacionJugador()
        {
            BaseDatosJugadores miBaseDatosJugadores =
                Juego.GetInstancia().baseDatosJugadores;
            Jugador ivan = miBaseDatosJugadores.getOrCreateJugador("Ivan");
            Assert.IsNotNull(ivan);
        }
        [TestMethod]
        public void TestNombreJugador()
        {
            BaseDatosJugadores miBaseDatosJugadores =
                Juego.GetInstancia().baseDatosJugadores;
            Jugador ivan = miBaseDatosJugadores.getOrCreateJugador("Ivan");
            Assert.AreEqual(ivan.nombre,"Ivan");
        }

    }
}
