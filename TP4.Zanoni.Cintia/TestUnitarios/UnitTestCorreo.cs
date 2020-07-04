using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTestCorreo
    {
        
        /// <summary>
        /// Verifica que la lista de Paquetes del Correo esté instanciada
        /// </summary>
        [TestMethod]
        public void InstanciaCorreoPaquetes()
        {
            //Arrange + Act
            Correo correo = new Correo();

            //Assert
            Assert.IsNotNull(correo.Paquetes);

        }

        /// <summary>
        /// Verifica que no se puedan cargar dos Paquetes con el mismo Tracking ID
        /// </summary>
        [TestMethod]
        public void CorreoTrackingIdRepetidoException()
        {
            //Arrange
            Correo correo = new Correo();
            Paquete paquete1 = new Paquete("primero", "1");
            Paquete paquete2 = new Paquete("segundo", "1");

            //Act
            correo += paquete1;

            //Assert
            Assert.ThrowsException<TrackingIdRepetidoException>(() => correo + paquete2);

        }
    }
}
