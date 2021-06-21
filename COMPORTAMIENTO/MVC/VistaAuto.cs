using System;
using System.Collections.Generic;
using System.Text;

namespace MVC
{
    class VistaAuto : IVistaAuto
    {
        public void DespliegaAuto(Auto pAuto)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("El auto");
            Console.WriteLine("{0} {1} ${2}", pAuto.Nombre, pAuto.Modelo, pAuto.Costo);
        }

        public int SolicitaEntrada()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1-Cambiar costo, 2-Cambiar modelo, 3-Salir");
            Console.WriteLine("Dame tu opcion");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;  
        }
    }
}
