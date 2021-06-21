using System;
using System.Collections.Generic;
using System.Text;

namespace MVC
{
    class ControladorAuto
    {
        // Referencia a la vista
        private IVistaAuto vista;

        // Referencia al modelo 
        private Auto modelo;
        private int opcion;

        public int Opcion { get => opcion; set => opcion = value; }

        public ControladorAuto(Auto pModelo, IVistaAuto pVista)
        {
            modelo = pModelo;
            vista = pVista;
        }

        public void DespliegaVista() 
        {
            vista.DespliegaAuto(modelo);
        }

        // Entrada de informacion
        public void Solicita() 
        {
            opcion = vista.SolicitaEntrada();

            if (opcion == 1)
                ActualizaCosto(modelo.Costo * 1.15);
            if (opcion == 2)
                ActualizaModelo();
        }

        public void ActualizaCosto(double pCosto) 
        {
            modelo.Costo = pCosto;
        }

        public void ActualizaModelo() 
        {
            Console.WriteLine("Dame el modelo");
            modelo.Modelo = Convert.ToInt32(Console.ReadLine());
        }
    }
}
