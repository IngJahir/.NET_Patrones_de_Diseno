﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class ComandoApagar : IComando
    {
        Automovil auto;

        public ComandoApagar(Automovil pAuto)
        {
            auto = pAuto;
        }

        public void ejecutar()
        {
            // Invocamos la accion correspondiente en el auto 
            auto.Apagar();            
        }
    }
}
