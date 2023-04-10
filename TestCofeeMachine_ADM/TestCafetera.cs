using CoffeMachine_ADM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCofeeMachine_ADM
{
    [TestClass]
    public class TestCafetera
    {
        [TestMethod]
        public void DeberiaDevolverVerdaderoSiExisteCafe()
        {
            Cafetera cafetera = new Cafetera(10);
            bool resultado = cafetera.HasCafe(5);
            Assert.AreEqual(true, resultado);
        }
        [TestMethod]
        public void DeberiaDevolverFalsoSiNoExisteCafe()
        {
            Cafetera cafetera = new Cafetera(10);
            bool resultado = cafetera.HasCafe(11);
            Assert.AreEqual(false, resultado);
        }
        [TestMethod]
        public void DeberiaRestarCafeAlaCafetera()
        {
            Cafetera cafetera = new Cafetera(10);
            bool resultado = cafetera.GiveCafe(7);
            Assert.AreEqual(3, cafetera.GetCantidadDeCafe());
        }
    }
}
