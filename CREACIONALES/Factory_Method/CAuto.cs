using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    class CAuto : IVehiculo
    {
        public void Acelerar()
        {
            Console.WriteLine("Oprime el pedal del acelarador");  
        }

        public void Encender()
        {
            Console.WriteLine("Introduce la llave y gira ");  
        }

        public void Frenar()
        {
            Console.WriteLine("Presiona el pedal del freno");
        }

        public void Girar()
        {
            Console.WriteLine("Toma el volante y giralo");
        }
    }
}
