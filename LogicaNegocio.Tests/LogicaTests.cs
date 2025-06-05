using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using LogicaNegocio;

namespace LogicaNegocio.Tests
{
    [TestClass]
    public class LogicaTests
    {
        [TestMethod]
        public void ObtenerCantidadAccidentesPorPlaca_DebeRetornarConteoCorrecto()
        {
            var placa = "XYZ123";
            var conteoEsperado = new ConteoAccidenteDTO { soloLatas = 3, heridos = 2, muertos = 0 };
            var mockFuenteDatos = new Mock<FuenteDeDatosFasecolda>();
            mockFuenteDatos.Setup(f => f.consultarCantidadAccidentesPorPlaca(placa)).Returns(conteoEsperado);

            var logica = new Logica(mockFuenteDatos.Object);
            var resultado = logica.ObtenerCantidadAccidentesPorPlaca(placa);

            Assert.IsNotNull(resultado);
            Assert.AreEqual(conteoEsperado.soloLatas, resultado.soloLatas);
            Assert.AreEqual(conteoEsperado.heridos, resultado.heridos);
            Assert.AreEqual(conteoEsperado.muertos, resultado.muertos);
        }
    }
}
