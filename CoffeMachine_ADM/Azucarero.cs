using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine_ADM
{
    public class Azucarero
    {
        private int cantidadDeAzucar;

        public Azucarero(int cantidadDeAzucar) 
        {
            this.cantidadDeAzucar = cantidadDeAzucar;
        }

        //Metodos
        public void SetCantidadDeAzucar(int cantidadDeAzucar) { this.cantidadDeAzucar = cantidadDeAzucar; }

        public int GetCantidadDeAzucar() { return this.cantidadDeAzucar; }

        public bool HasAzucar(int cantidadDeAzucar)
        {
            if(this.cantidadDeAzucar >= cantidadDeAzucar) { return true; }
            return false;
        }

        public int GiveAzucar(int cantidadDeAzucar)
        {
            if(this.cantidadDeAzucar >= cantidadDeAzucar)
            {
                this.cantidadDeAzucar -= cantidadDeAzucar;
                return this.cantidadDeAzucar;
            }
            return 0;

        }
    }
}
