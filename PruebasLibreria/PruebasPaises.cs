using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriasJuego;

namespace PruebasLibreria
{
    [TestClass]
    public class PruebasPaises
    {
        [TestMethod]
        public void TestEspa�a_Capital()
        {
            IBaseDatosGeografica miBaseDatosGeografica = Juego.GetInstancia().baseDatosGeografica;
            IPais espa�a = miBaseDatosGeografica.getPais("Espa�a");
            Assert.AreEqual(espa�a.capital,"Madrid");

        }

        [TestMethod]
        public void TestEspa�a_Nombre()
        {
            IBaseDatosGeografica miBaseDatosGeografica =
                Juego.GetInstancia().baseDatosGeografica;
            IPais espa�a = miBaseDatosGeografica.getPais("Espa�a");
            Assert.AreEqual(espa�a.nombre, "Espa�a");

        }

        [TestMethod]
        public void TestEspa�a_Continente()
        {

            IBaseDatosGeografica miBaseDatosGeografica =
                Juego.GetInstancia().baseDatosGeografica;
            IPais espa�a = miBaseDatosGeografica.getPais("Espa�a");
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");
            Assert.AreEqual(espa�a.continente, europa);

        }
    }
}
