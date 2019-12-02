using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriasJuego;

namespace PruebasLibreria
{
    [TestClass]
    public class PruebasPaises
    {
        [TestMethod]
        public void TestEspaña_Capital()
        {
            BaseDatosGeografica miBaseDatosGeografica = null;
            Pais españa = miBaseDatosGeografica.getPais("España");
            Assert.AreEqual(españa.capital,"Madrid");

        }

        [TestMethod]
        public void TestEspaña_Nombre()
        {
            Pais españa = null;
            Assert.AreEqual(españa.nombre, "España");

        }

        [TestMethod]
        public void TestEspaña_Continente()
        {
            Pais españa = null;
            Continente europa = null;
            Assert.AreEqual(españa.continente, europa);

        }
    }
}
