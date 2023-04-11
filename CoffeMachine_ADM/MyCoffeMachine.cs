using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine_ADM
{
    public class MyCoffeMachine
    {
        private int cafe { get; set; } = 0;
        private int azucar { get; set; } = 0;
        private int cantidadVaso { get; set; } = 0;
        private string tipoVaso { get; set; } = "";

        Cafetera cafetera = new Cafetera(0);
        Vaso vasosPequenos = new Vaso(5, 10);
        Vaso vasosMediano = new Vaso(5, 20);
        Vaso vasosGrande = new Vaso(5, 30);
        Azucarero azucarero = new Azucarero(20);
        MaquinaDeCafe maquinaDeCafe = new MaquinaDeCafe();

        public MyCoffeMachine()
        {
            //setiando la cafetera dependiendo cual sea el contenido de los vasos creados
            int contenidoCafe = vasosPequenos.GetContenido() + vasosMediano.GetContenido() + vasosGrande.GetContenido();
            cafetera.SetCantidadDeCafe(contenidoCafe);

            maquinaDeCafe.SetVasosPequeno(vasosPequenos);
            maquinaDeCafe.SetVasosMediano(vasosMediano);
            maquinaDeCafe.SetvasosGrande(vasosGrande);
            maquinaDeCafe.SetAzucarero(azucarero);
            maquinaDeCafe.SetCafetera(cafetera);
        }

        public void Run()
        {
            bool flag = true;

            while (flag)
            {
                cafe = 0;
                azucar = 0;
                cantidadVaso = 0;
                flag = QuiereCafe();
            }

            Console.Clear();

            Console.WriteLine("Gracias por su tiempo, hasta la proxima!");
        }

        private bool QuiereCafe()
        {
            try
            {

                Console.WriteLine("----- SELECCIONE SU CAFE DE PREFERENCA -----\n");

                Console.WriteLine($"Cantidad de cafe disponible : {maquinaDeCafe.GetCafetera().GetCantidadDeCafe()} Unidades");
                Console.WriteLine($"Cantidad de azucar disponible : {maquinaDeCafe.GetAzucarero().GetCantidadDeAzucar()} Unidades\n");

                Console.WriteLine("--------------------------------------------\n");

                Console.WriteLine("Tipos de vasos:");
                Console.WriteLine("Seleccione el numero de la opcion que desea:\n");


                Console.WriteLine($"1 - Vasos Grande Cantidad de cafe consumible : {maquinaDeCafe.GetVasosGrandes().GetContenido()} Unidades. Cantidad de vasos disponible : {maquinaDeCafe.GetVasosGrandes().GetCantidadVasos()}");
                Console.WriteLine($"2 - Vasos Mediano Cantidad de cafe consumible : {maquinaDeCafe.GetVasosMedianos().GetContenido()} Unidades. Cantidad de vasos disponible : {maquinaDeCafe.GetVasosMedianos().GetCantidadVasos()}");
                Console.WriteLine($"3 - Vasos Pequeño Cantidad de cafe consumible : {maquinaDeCafe.GetVasosPequenos().GetContenido()} Unidades. Cantidad de vasos disponible : {maquinaDeCafe.GetVasosPequenos().GetCantidadVasos()}");
                Console.WriteLine($"4- No deseo cafe.\n");

                cafe = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                if (cafe >= 1 && cafe < 4)
                {
                    if (!VasosValidator(cafe))
                    {
                        return true;
                    }

                    return QuiereAzucar(cafe == 1 ? "Grande" : cafe == 2 ? "Mediano" : "Pequeño");
                }
                else if (cafe == 4)
                {
                    return false;
                }
                else
                {
                    return MensajeError();
                }

            }
            catch
            {
                return MensajeError();
            }
        }

        private bool VasosValidator(int glass)
        {
            bool existenVaso = true;
            bool existeCafe = true;

            Console.WriteLine($"Cuantos vasos de cafe {tipoVaso} desea?");
            cantidadVaso = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (glass == 1)
            {
                tipoVaso = "grandes";
                if (maquinaDeCafe.GetVasosGrandes().GetCantidadVasos() == 0 || maquinaDeCafe.GetVasosGrandes().GetCantidadVasos() < cantidadVaso)
                {
                    existenVaso = false;
                }
                else if (maquinaDeCafe.GetVasosGrandes().GetContenido() > maquinaDeCafe.GetCafetera().GetCantidadDeCafe())
                {
                    existeCafe = false;
                }
            }
            else if (glass == 2)
            {
                tipoVaso = "medianos";

                if (maquinaDeCafe.GetVasosMedianos().GetCantidadVasos() == 0 || maquinaDeCafe.GetVasosMedianos().GetCantidadVasos() < cantidadVaso)
                {
                    existenVaso = false;
                }
                else if (maquinaDeCafe.GetVasosMedianos().GetContenido() > maquinaDeCafe.GetCafetera().GetCantidadDeCafe())
                {
                    existeCafe = false;
                }
            }
            else
            {
                tipoVaso = "pequeños";

                if (maquinaDeCafe.GetVasosPequenos().GetCantidadVasos() == 0 || maquinaDeCafe.GetVasosPequenos().GetCantidadVasos() < cantidadVaso)
                {
                    existenVaso = false;
                }
                else if (maquinaDeCafe.GetVasosPequenos().GetContenido() > maquinaDeCafe.GetCafetera().GetCantidadDeCafe())
                {
                    existeCafe = false;
                }
            }

            if (!existenVaso)
            {
                Console.WriteLine($"No existe esa cantidad de vasos {tipoVaso} disponibles en el sistema.\n");

                Console.WriteLine("Pulse cualquier tecla para continuar.");

                Console.ReadKey();

                Console.Clear();

                return false;
            }

            if (!existeCafe)
            {
                Console.WriteLine($"No hay suficiente cafe para el vaso {tipoVaso}.\n");

                Console.WriteLine("Pulse cualquier tecla para continuar.");

                Console.ReadKey();

                Console.Clear();

                return false;
            }

            return true;
        }

        private bool QuiereAzucar(string glass)
        {
            bool flag = true;
            azucar = 0;

            while (flag)
            {
                try
                {
                    Console.WriteLine($"Tipo de vaso seleccionada: {glass} y la cantidad es: {cantidadVaso}");

                    Console.WriteLine($"Que cantidad de azucar desea ?");

                    azucar = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    if (AzucarValidator(azucar))
                    {
                        switch (tipoVaso)
                        {
                            case "grandes":
                                var vasoGrande = maquinaDeCafe.GetTipoDeVaso("grande");
                                var mensaje = maquinaDeCafe.GetVasoDeCafe(vasoGrande, cantidadVaso, azucar);
                                if (mensaje == "Felicitaciones")
                                {
                                    Console.WriteLine("Su cafe esta listo.");
                                    Console.WriteLine(mensaje);
                                }
                                else
                                {
                                    Console.WriteLine(mensaje);
                                }
                                break;

                            case "medianos":
                                var vasoMediano = maquinaDeCafe.GetTipoDeVaso("mediano");
                                mensaje = maquinaDeCafe.GetVasoDeCafe(vasoMediano, cantidadVaso, azucar);
                                if (mensaje == "Felicitaciones")
                                {
                                    Console.WriteLine("Su cafe esta listo.");
                                    Console.WriteLine(mensaje);
                                }
                                else
                                {
                                    Console.WriteLine(mensaje);
                                }
                                break;

                            case "pequeños":
                                var vasoPequeno = maquinaDeCafe.GetTipoDeVaso("pequeno");
                                mensaje = maquinaDeCafe.GetVasoDeCafe(vasoPequeno, cantidadVaso, azucar);
                                if (mensaje == "Felicitaciones")
                                {
                                    Console.WriteLine("Su cafe esta listo.");
                                    Console.WriteLine(mensaje);
                                }
                                else
                                {
                                    Console.WriteLine(mensaje);
                                }
                                break;
                        }
                        return MasCafe();
                    }
                }
                catch
                {
                    azucar = 0;
                    flag = MensajeError();
                }
            }

            return flag;
        }

        private bool AzucarValidator(int suggar)
        {
            bool HasSugar = true;

            if (maquinaDeCafe.GetAzucarero().GetCantidadDeAzucar() < suggar)
            {
                HasSugar = false;
            }

            if (suggar < 0)
            {
                Console.WriteLine($"El minimo de azucar es 0.\n");

                Console.WriteLine("Pulse cualquier tecla para continuar.");

                Console.ReadKey();

                Console.Clear();

                return false;
            }

            if (!HasSugar)
            {
                Console.WriteLine($"No hay suficiente azucar.\n");

                Console.WriteLine("Pulse cualquier tecla para continuar.");

                Console.ReadKey();

                Console.Clear();

                return false;
            }
            return true;
        }
        private bool MasCafe()
        {
            while (true)
            {
                Console.WriteLine($"Desea tomar otro cafe?[y/n]");

                var anw = Console.ReadKey();
                if (anw.Key.ToString().ToLower() == "y")
                {
                    Console.Clear();
                    return true;
                }
                else if (anw.Key.ToString().ToLower() == "n")
                {
                    Console.Clear();
                    return false;
                }
                else
                {
                    MensajeError();
                }

            }
        }
        private bool MensajeError()
        {
            Console.Clear();

            Console.WriteLine("Favor de ingresar un valor valido.\n");

            Console.WriteLine("Pulse cualquier tecla para continuar.");

            Console.ReadKey();

            Console.Clear();

            return true;
        }
    }
}
