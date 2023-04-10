using CoffeMachine_ADM;

namespace TestCofeeMachine_ADM
{
    [TestClass]
    public class TestVaso
    {
        [TestMethod]
        public void DeberiaDevolverVerdaderosSiExistenVasos()
        {
            Vaso vasosPequenos = new Vaso(2, 10);
            bool resultado = vasosPequenos.HasVasos(1);
            Assert.AreEqual(true, resultado);
        }
        [TestMethod]
        public void DeberiaDevolverFalsoSiNoExistenVasos()
        {
            Vaso vasosPequenos = new Vaso(1, 10);
            bool resultado = vasosPequenos.HasVasos(2);
            Assert.AreEqual(false, resultado);
        }
        [TestMethod]
        public void DeberiaRestarCantidadDeVaso()
        {
            Vaso vasosPequenos = new Vaso(5, 10);
            vasosPequenos.GiveVasos(1);
            Assert.AreEqual(4, vasosPequenos.GetCantidadVasos());
        }
    }
}