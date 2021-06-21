using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class ElementoL : Elemento
    {
        public ElementoL(Elemento pHijo, Elemento pSiguiente)
        {
            siguiente = pSiguiente;
            hijo = pHijo;
        }

        public override void Aceptar(IVisitante pVisitante)
        {
            // Nos mandamos como parametro para que el visitante
            // procese lo necesario
            pVisitante.Visitar(this);
        }
    }
}
