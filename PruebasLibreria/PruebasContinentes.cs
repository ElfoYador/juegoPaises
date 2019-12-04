using LibreriasJuego;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace PruebasLibreria
{
    [TestClass]
    public class PruebasContinentes
    {
        [TestMethod]
        public void TestEuropa_Nombre()
        {
            IBaseDatosGeografica miBaseDatosGeografica =
                Juego.GetInstancia().baseDatosGeografica;
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");
            Assert.AreEqual(europa.nombre, "Europa");
        }

        [TestMethod]
        public void TestEuropa_Paises()
        {
            IBaseDatosGeografica miBaseDatosGeografica =
                Juego.GetInstancia().baseDatosGeografica;
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");
            Assert.AreNotEqual(europa.paises.Count, 0);
        }

        [TestMethod]
        public void TestEuropa_España()
        {
            IBaseDatosGeografica miBaseDatosGeografica = Juego.GetInstancia().baseDatosGeografica;
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");
            IPais españa = europa.getPais("España");
            Assert.IsNotNull(españa);
        }
        [TestMethod]
        public void TestEuropa_Nueva_Zelanda()
        {
            IBaseDatosGeografica miBaseDatosGeografica =
                Juego.GetInstancia().baseDatosGeografica;
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");
            // IPais nuevaZelanda = europa.getPais("Nueva Zelanda");
            Assert.ThrowsException<KeyNotFoundException> (()=>  europa.getPais("Nueva Zelanda")); 
           /* es el equivalente a la funcion lambda, en vez de ejecutar la funcionALlamar la pasamos como referencia 
            * asignada a una variable para que la ejecute el Assert; como en programacion funcional
            * Action funcionALlamar = recuperarNuevaZelanda;
            Assert.ThrowsException<KeyNotFoundException>(funcionALlamar);*/
        }

        void recuperarNuevaZelanda (IContinente c)
        {
            c.getPais("Nueva Zelanda");
        }
    }
}
