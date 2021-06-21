using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    interface IElemento
    {
        void Aceptar(IVisitante pVisitante);
    }
}
