using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Director
    {
        public void Construye(IBuilder pConstruccion)
        {
            /* 
            Aqui el Director indica los pasos para hacer la construccion 
            pero el constructor es el que se encarga de construir segun
            esta especificacion.
             */

            pConstruccion.ConstrulleMotor();
            pConstruccion.ConstrulleCarroceria();
            pConstruccion.ConstrulleLlantas();

        }
    }
}
