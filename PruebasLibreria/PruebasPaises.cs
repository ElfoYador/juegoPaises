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
            IBaseDatosGeografica miBaseDatosGeografica = null;
            IPais espa�a = miBaseDatosGeografica.getPais("Espa�a");
            Assert.AreEqual(espa�a.capital,"Madrid");

        }

        [TestMethod]
        public void TestEspa�a_Nombre()
        {
            IPais espa�a = null;
            Assert.AreEqual(espa�a.nombre, "Espa�a");

        }

        [TestMethod]
        public void TestEspa�a_Continente()
        {
            IPais espa�a = null;
            IContinente europa = null;
            Assert.AreEqual(espa�a.continente, europa);

        }
    }
}
