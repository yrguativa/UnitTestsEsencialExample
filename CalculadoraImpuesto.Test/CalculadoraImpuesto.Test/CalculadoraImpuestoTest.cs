using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraImpuesto.Test
{
    /*
     * REQUERIMIENTOS
     *=> Obtener el IVA apartir del moto de reserva. (16%)
     *=> Obtener el impuesto estatal sobre hospedaje partir del moto de un reserva.
     * Obtner el oto toral de la reserva.(fon impuesto incluidos)
     */

    [TestClass]
    public class CalculadoraImpuestoTest
    {
        [TestMethod]
        public void ImpuestoTest()
        {
            // Arrange
            CalculadoraImpuesto ci = new CalculadoraImpuesto();

            // Act
            decimal iva = ci.ObtenerIVA(1550.00m);

            //Assert
            //iva% = 16%
            //monto reseva = 1550
            //iva = 1550 * 0.16 = 248
            Assert.AreEqual(248.00m, iva);
        }

        [TestMethod]
        public void ISHTest()
        {
            // Arrange
            CalculadoraImpuesto ci = new CalculadoraImpuesto();

            // Act
            decimal ish = ci.ObtenerIHS(1550.00m, 0.03m);

            //Assert
            //ish = 0.03
            //monto reseva = 1550
            //iva = 1550 * 0.03 = 46.5
            Assert.AreEqual(46.5m, ish);
        }



        [TestMethod]
        public void MontoTotalReservaTest()
        {
            // Arrange
            CalculadoraImpuesto ci = new CalculadoraImpuesto();

            // Act
            decimal iva = ci.ObtenerIHS(1550.00m, 0.03m);

            //Assert
            //ish = 0.03
            //monto reseva = 1550
            //iva = 1550 * 0.03 = 46.5
            Assert.AreEqual(46.5m, iva);
        }
    }
}
