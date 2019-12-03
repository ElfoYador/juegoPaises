using LibreriasJuego;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PruebasLibreria
{
    [TestClass]
    public class PruebasContinentes
    {
        [TestMethod]
        public void TestEuropa_Nombre()
        {
            BaseDatosGeografica miBaseDatosGeografica =
                Juego.GetInstancia().baseDatosGeografica;
            Continente europa = miBaseDatosGeografica.getContinente("Europa");
            Assert.AreEqual(europa.nombre, "Europa");
        }

        [TestMethod]
        public void TestEuropa_Paises()
        {
            BaseDatosGeografica miBaseDatosGeografica =
                Juego.GetInstancia().baseDatosGeografica;
            Continente europa = miBaseDatosGeografica.getContinente("Europa");
            Assert.AreNotEqual(europa.paises.Count, 0);
        }

        [TestMethod]
        public void TestEuropa_España()
        {
            BaseDatosGeografica miBaseDatosGeografica =
                Juego.GetInstancia().baseDatosGeografica;
            Continente europa = miBaseDatosGeografica.getContinente("Europa");
            Pais españa = europa.getPais("España");
            Assert.IsNotNull(españa);
        }
        [TestMethod]
        public void TestEuropa_Nueva_Zelanda()
        {
            BaseDatosGeografica miBaseDatosGeografica =
                Juego.GetInstancia().baseDatosGeografica;
            Continente europa = miBaseDatosGeografica.getContinente("Europa");
            Pais nuevaZelanda = europa.getPais("Nueva Zelanda");
            Assert.IsNull(nuevaZelanda);
        }

    }
}
