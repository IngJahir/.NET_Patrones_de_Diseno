using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    class Program
    {
        static void Main(string [] args) 
        {
            string dato;
            int dinero;
            IVehiculo vehiculo;

            Console.WriteLine("Cuanto dinero tienes para tu vehiculo");
            dato = Console.ReadLine();
            dinero = Convert.ToInt32(dato);

            // Obtenemos el vehiculo de la fabrica
            vehiculo = CCreador.MetodoFabrica(dinero);

            vehiculo.Encender();
            vehiculo.Acelerar();
            vehiculo.Frenar();
            vehiculo.Girar();
        }
    }
}
