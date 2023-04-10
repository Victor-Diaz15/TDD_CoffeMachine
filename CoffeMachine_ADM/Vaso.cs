using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine_ADM
{
    public class Vaso
    {
        private int cantidadVasos;
        private int contenido;

        public Vaso(int cantidadVasos, int contenido)
        {
            this.cantidadVasos = cantidadVasos;
            this.contenido = contenido;
        }


        //Metodos
        public void SetCantidadVasos(int cantidadVasos) {this.cantidadVasos = cantidadVasos; }

        public int GetCantidadVasos() {  return this.cantidadVasos; }

        public void SetContenido(int contenido) { this.contenido = contenido; }

        public int GetContenido() {  return this.contenido; }

        public bool HasVasos(int cantidadVasos)
        {
            if (this.cantidadVasos == 0 || this.cantidadVasos < cantidadVasos) return false;
            return true;
        }

        public int GiveVasos(int cantidadVasos)
        {
            if (this.cantidadVasos < cantidadVasos) return 0;
            this.cantidadVasos -= cantidadVasos;
            return this.cantidadVasos;
        }


    }
}
