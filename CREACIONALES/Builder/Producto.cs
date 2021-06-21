using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Producto
    {
        private IMotor motor;
        private ICarroceria carroceria;
        private ILlantas llantas;

        public void ColocarMotor(IMotor pmotor)
        {
            motor = pmotor;
            Console.WriteLine("Se ha colocado el motor: {0}", motor.especificaciones());
        }

        public void ColocarCarroceria(ICarroceria pcarroceria)
        {
            carroceria = pcarroceria;
            Console.WriteLine("Se ha colocado la carroceria: {0}", carroceria.caracteristicas());
        }

        public void ColocarLlantas(ILlantas pllantas)
        {
            llantas = pllantas;
            Console.WriteLine("Se ha colocado las llantas: {0}", llantas.informacion());
        }

        public void MostrarAuto()
        {
            Console.WriteLine("Tu auto tiene {0}, {1}, {2},",
                motor.especificaciones(), carroceria.caracteristicas(), llantas.informacion());
        }
    }
}
