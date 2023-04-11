using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine_ADM
{
    public class MaquinaDeCafe
    {
        private Cafetera cafe;
        private Vaso vasosPequenos;
        private Vaso vasosMedianos;
        private Vaso vasosGrandes;
        private Azucarero azucar;

        //public MaquinaDeCafe() { }


        //Metodos
        public Vaso GetTipoDeVaso(string tipoDeVaso)
        {
            if(tipoDeVaso == "pequeno")
                return this.vasosPequenos;
            if(tipoDeVaso == "mediano")
                return this.vasosMedianos;
            
            return this.vasosGrandes;


        }

        public string GetVasoDeCafe(Vaso tipoDeVaso, int cantidadDeVasos, int cantidadDeAzucar) 
        {
            if (tipoDeVaso == this.vasosPequenos)
            {
                if (this.cafe.GetCantidadDeCafe() >= this.vasosPequenos.GetContenido())
                {
                    if (this.vasosPequenos.GetCantidadVasos() >= cantidadDeVasos)
                    {
                        if (this.azucar.GetCantidadDeAzucar() >= cantidadDeAzucar)
                        {
                            int vasos = this.vasosPequenos.GetCantidadVasos();
                            if (vasos > 0)
                            {
                                vasos -= cantidadDeVasos;
                                this.vasosPequenos.SetCantidadVasos(vasos);
                            }

                            int azucar = this.azucar.GetCantidadDeAzucar();
                            if (azucar > 0)
                            {
                                azucar -= cantidadDeAzucar;
                                this.azucar.SetCantidadDeAzucar(azucar);
                            }

                            int contenidoARestar = cantidadDeVasos * 10;
                            int contenidoNuevo = this.vasosPequenos.GetContenido() - contenidoARestar;
                            this.vasosPequenos.SetContenido(contenidoNuevo);
                            int cafetera = this.cafe.GetCantidadDeCafe();
                            if (cafetera > 0)
                            {
                                cafetera -= contenidoARestar;
                                this.cafe.SetCantidadDeCafe(cafetera);
                            }
                        }
                        else
                        {
                            return "No hay azucar";
                        }
                    }
                    else
                    {
                        return "No hay vasos";
                    }

                }
                else
                {
                    return "No hay cafe";
                }
            }
            else if(tipoDeVaso == this.vasosMedianos)
            {
                if (this.cafe.GetCantidadDeCafe() >= this.vasosMedianos.GetContenido())
                {
                    if (this.vasosMedianos.GetCantidadVasos() >= cantidadDeVasos)
                    {
                        if (this.azucar.GetCantidadDeAzucar() >= cantidadDeAzucar)
                        {
                            int vasos = this.vasosMedianos.GetCantidadVasos();
                            if (vasos > 0)
                            {
                                vasos -= cantidadDeVasos;
                                this.vasosMedianos.SetCantidadVasos(vasos);
                            }

                            int azucar = this.azucar.GetCantidadDeAzucar();
                            if (azucar > 0)
                            {
                                azucar -= cantidadDeAzucar;
                                this.azucar.SetCantidadDeAzucar(azucar);
                            }

                            int contenidoARestar = cantidadDeVasos * 20;
                            int contenidoNuevo = this.vasosMedianos.GetContenido() - contenidoARestar;
                            this.vasosMedianos.SetContenido(contenidoNuevo);
                            int cafetera = this.cafe.GetCantidadDeCafe();
                            if (cafetera > 0)
                            {
                                cafetera -= contenidoARestar;
                                this.cafe.SetCantidadDeCafe(cafetera);
                            }
                            
                        }
                        else
                        {
                            return "No hay azucar";
                        }
                    }
                    else
                    {
                        return "No hay vasos";
                    }

                }
                else
                {
                    return "No hay cafe";
                }
            }
            else
            {
                if (this.cafe.GetCantidadDeCafe() >= this.vasosGrandes.GetContenido())
                {
                    if (this.vasosGrandes.GetCantidadVasos() >= cantidadDeVasos)
                    {
                        if (this.azucar.GetCantidadDeAzucar() >= cantidadDeAzucar)
                        {
                            int vasos = this.vasosGrandes.GetCantidadVasos();
                            if (vasos > 0)
                            {
                                vasos -= cantidadDeVasos;
                                this.vasosGrandes.SetCantidadVasos(vasos);
                            }

                            int azucar = this.azucar.GetCantidadDeAzucar();
                            if (azucar > 0)
                            {
                                azucar -= cantidadDeAzucar;
                                this.azucar.SetCantidadDeAzucar(azucar);
                            }

                            int contenidoARestar = cantidadDeVasos * 30;
                            int contenidoNuevo = this.vasosGrandes.GetContenido() - contenidoARestar;
                            this.vasosGrandes.SetContenido(contenidoNuevo);
                            int cafetera = this.cafe.GetCantidadDeCafe();
                            if (cafetera > 0)
                            {
                                cafetera -= contenidoARestar;
                                this.cafe.SetCantidadDeCafe(cafetera);
                            }
                        }
                        else
                        {
                            return "No hay azucar";
                        }
                    }
                    else
                    {
                        return "No hay vasos";
                    }

                }
                else
                {
                    return "No hay cafe";
                }
            }
            return "Felicitaciones";

        }

        public Vaso GetVasosPequenos()
        {
            return this.vasosPequenos;
        }

        public Vaso GetVasosMedianos()
        {
            return this.vasosMedianos;
        }

        public Vaso GetVasosGrandes()
        {
            return this.vasosGrandes;
        }

        public Cafetera GetCafetera()
        {
            return this.cafe;
        }

        public Azucarero GetAzucarero()
        {
            return this.azucar;
        }

        //Setters
        public void SetCafetera(Cafetera cafetera) { this.cafe = cafetera; }

        public void SetVasosPequeno(Vaso vasosPequenos) { this.vasosPequenos = vasosPequenos; }
        public void SetVasosMediano(Vaso vasosMediano) { this.vasosMedianos = vasosMediano; }

        public void SetvasosGrande(Vaso vasosGrande) { this.vasosGrandes = vasosGrande; }
        public void SetAzucarero(Azucarero azucarero) { this.azucar = azucarero; }
    }
}
