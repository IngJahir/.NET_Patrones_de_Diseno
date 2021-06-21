using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    class CBici : IVehiculo
    {
        public void Acelerar()
        {
            Console.WriteLine("Pedalea fuerte para acelerar");
        }

        public void Encender()
        {
            Console.WriteLine("Las bicis no necesitan encendido");
        }

        public void Frenar()
        {
            Console.WriteLine("Presiona premero el freno trasero");
        }

        public void Girar()
        {
            Console.WriteLine("Usa el manubrio");
        }
    }
}
