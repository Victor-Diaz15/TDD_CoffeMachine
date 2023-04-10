using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine_ADM
{
    public class Cafetera
    {
        private int cantidadCafe;

        public Cafetera(int cantidadCafe) 
        {
            this.cantidadCafe = cantidadCafe;
        }

        //Metodos
        public void SetCantidadDeCafe(int cantidadDeCafe) { this.cantidadCafe = cantidadDeCafe; }

        public int GetCantidadDeCafe() 
        {  
            return this.cantidadCafe; 
        }

        public bool HasCafe(int cantidadCafe)
        {
            if(this.cantidadCafe > cantidadCafe) return true;
            return false;
        }

        public bool GiveCafe(int cantidadCafe) 
        {  
            if(this.cantidadCafe > cantidadCafe)
            {
                this.cantidadCafe -= cantidadCafe;
                return true;
            }
            return false; 
        }
    }
}
