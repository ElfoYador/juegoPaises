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
            IBaseDatosGeografica miBaseDatosGeografica = null;
            IPais españa = miBaseDatosGeografica.getPais("España");
            Assert.AreEqual(españa.capital,"Madrid");

        }

        [TestMethod]
        public void TestEspaña_Nombre()
        {
            IPais españa = null;
            Assert.AreEqual(españa.nombre, "España");

        }

        [TestMethod]
        public void TestEspaña_Continente()
        {
            IPais españa = null;
            IContinente europa = null;
            Assert.AreEqual(españa.continente, europa);

        }
    }
}
