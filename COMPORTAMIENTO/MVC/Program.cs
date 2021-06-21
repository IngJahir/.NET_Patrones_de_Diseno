using System;

namespace MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos el modelo
            Auto miAuto = new Auto("March",2019,2500000);

            // Creamos la vista
            IVistaAuto miVista = new VistaAuto();

            // Creamos el controlador 
            ControladorAuto miControlador = new ControladorAuto(miAuto, miVista);

            while (miControlador.Opcion !=3)
            {
                miControlador.DespliegaVista();
                miControlador.Solicita();
            }
        }
    }
}
