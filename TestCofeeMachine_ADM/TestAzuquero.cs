using CoffeMachine_ADM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCofeeMachine_ADM
{
    [TestClass]
    public class TestAzuquero
    {
        private Azucarero azuquero;

        [TestInitialize]
        public void SetUp()
        {
            azuquero = new Azucarero(10);
        }

        [TestMethod]
        public void DeberiaDevolverVerdaderoSiHaySuficienteAzucarEnElAzuquero()
        {
            bool resultado = azuquero.HasAzucar(5);
            Assert.AreEqual(true, resultado);

            resultado = azuquero.HasAzucar(10);
            Assert.AreEqual(true, resultado);

        }

        [TestMethod]
        public void DeberiaDevolverFalsoPorqueNoHaySuficienteAzucarEnElAzuquero()
        {
            bool resultado = azuquero.HasAzucar(15);
            Assert.AreEqual(false, resultado);

        }
        [TestMethod]
        public void DeberiaRestarAzucarAlAzuquero()
        {
            azuquero.GiveAzucar(5);
            Assert.AreEqual(5, azuquero.GetCantidadDeAzucar());
            azuquero.GiveAzucar(2);
            Assert.AreEqual(3, azuquero.GetCantidadDeAzucar());
        }

    }
}
