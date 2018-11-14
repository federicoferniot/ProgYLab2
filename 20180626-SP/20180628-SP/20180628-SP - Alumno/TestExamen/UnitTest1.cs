using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;
using System.Collections.Generic;

namespace TestExamen
{
    [TestClass]
    public class UnitTest1
    {
        private static int contadorEvento;
        [TestMethod]
        public void TestSerializarVotacionConRutaVacia_LanzaExcepcionErrorArchivoException()
        {
        }

        [TestMethod]
        public void TestEventoVotacion_SeLanzaTantasVecesComoSenadores()
        {
            Dictionary<string, Votacion.EVoto> senadores = new Dictionary<string, Votacion.EVoto>();
            senadores.Add("1", Votacion.EVoto.Esperando);
            senadores.Add("2", Votacion.EVoto.Esperando);
            Votacion votacion = new Votacion("Ley", senadores);
            votacion.EventoVotoEfectuado += ManejadorContador;

            votacion.Simular();

            Assert.AreEqual(2, UnitTest1.contadorEvento);

        }

        void ManejadorContador(string senador, Votacion.EVoto voto)
        {
            UnitTest1.contadorEvento++;
        }
    }
}
