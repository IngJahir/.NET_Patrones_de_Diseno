using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class ComandoEncender : IComando
    {
        Automovil auto;

        public ComandoEncender(Automovil pAuto)
        {
            auto = pAuto;
        }

        public void ejecutar()
        {
            // Invocamos la accion correspondiente en el auto
            auto.Encender();
        }
    }
}
