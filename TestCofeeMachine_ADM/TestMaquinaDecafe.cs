using CoffeMachine_ADM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCofeeMachine_ADM
{
    [TestClass]
    public class TestMaquinaDecafe
    {
        Cafetera cafetera;
        Vaso vasosPequenos;
        Vaso vasosMediano;
        Vaso vasosGrande;
        Azucarero azucarero;
        MaquinaDeCafe maquinaDeCafe;

        [TestInitialize]
        public void SetUp()
        {
            cafetera = new Cafetera(50);
            vasosPequenos = new Vaso(5, 10);
            vasosMediano = new Vaso(5, 20);
            vasosGrande = new Vaso(5, 30);
            azucarero = new Azucarero(20);

            maquinaDeCafe = new MaquinaDeCafe();
            maquinaDeCafe.SetCafetera(cafetera);
            maquinaDeCafe.SetVasosPequeno(vasosPequenos);
            maquinaDeCafe.SetVasosMediano(vasosMediano);
            maquinaDeCafe.SetvasosGrande(vasosGrande);
            maquinaDeCafe.SetAzucarero(azucarero);
        }

        [TestMethod]
        public void DeberiaDevolverUnVasoPequeno()
        {
            Vaso vaso = maquinaDeCafe.GetTipoDeVaso("pequeno");
            Assert.AreEqual(maquinaDeCafe.GetVasosPequenos(), vaso);
        }

        [TestMethod]
        public void DeberiaDevolverUnVasoMediano()
        {
            MaquinaDeCafe maquinaDeCafe = new MaquinaDeCafe();
            Vaso vaso = maquinaDeCafe.GetTipoDeVaso("mediano");
            Assert.AreEqual(maquinaDeCafe.GetVasosMedianos(), vaso);
        }

        [TestMethod]
        public void DeberiaDevolverUnVasoGrande()
        {
            Vaso vaso = maquinaDeCafe.GetTipoDeVaso("grande");
            Assert.AreEqual(maquinaDeCafe.GetVasosGrandes() , vaso);
        }

        [TestMethod]
        public void DeberiaDevolverNoHayVasos()
        {
            Vaso vaso = maquinaDeCafe.GetTipoDeVaso("pequeno");
            string resultado = maquinaDeCafe.GetVasoDeCafe(vaso, 10, 2);
            Assert.AreEqual("No hay vasos", resultado);
        }

        [TestMethod]
        public void DeberiaDevolverNoHayCafe()
        {
            cafetera = new Cafetera(5);
            maquinaDeCafe.SetCafetera(cafetera);

            Vaso vaso = maquinaDeCafe.GetTipoDeVaso("pequeno");
            string resultado = maquinaDeCafe.GetVasoDeCafe(vaso, 1, 2);
            Assert.AreEqual("No hay cafe", resultado);
        }

        [TestMethod]
        public void DeberiaDevolverNoHayAzucar()
        {
            azucarero = new Azucarero(2);
            maquinaDeCafe.SetAzucarero(azucarero);
            Vaso vaso = maquinaDeCafe.GetTipoDeVaso("pequeno");
            string resultado = maquinaDeCafe.GetVasoDeCafe(vaso, 1, 3);
            Assert.AreEqual("No hay azucar", resultado);
        }

        [TestMethod]
        public void DeberiaRestarCafe()
        {
            Vaso vaso = maquinaDeCafe.GetTipoDeVaso("pequeno");
            maquinaDeCafe.GetVasoDeCafe(vaso, 1, 3);
            int resultado = maquinaDeCafe.GetCafetera().GetCantidadDeCafe();
            Assert.AreEqual(40, resultado);
        }

        [TestMethod]
        public void DeberiaRestarVaso()
        {
            Vaso vaso = maquinaDeCafe.GetTipoDeVaso("pequeno");
            maquinaDeCafe.GetVasoDeCafe(vaso, 1, 3);
            int resultado = maquinaDeCafe.GetVasosPequenos().GetCantidadVasos();
            Assert.AreEqual(4, resultado);
        }

        [TestMethod]
        public void DeberiaRestarAzucar()
        {
            Vaso vaso = maquinaDeCafe.GetTipoDeVaso("pequeno");
            maquinaDeCafe.GetVasoDeCafe(vaso, 1, 3);
            int resultado = maquinaDeCafe.GetAzucarero().GetCantidadDeAzucar();
            Assert.AreEqual(17, resultado);
        }

        [TestMethod]
        public void DeberiaDevolverFelicitaciones()
        {
            Vaso vaso = maquinaDeCafe.GetTipoDeVaso("pequeno");
            string resultado = maquinaDeCafe.GetVasoDeCafe(vaso, 1, 3);
            Assert.AreEqual("Felicitaciones", resultado);
        }

    }
}
