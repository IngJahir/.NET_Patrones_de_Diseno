using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    interface IVisitante
    {
        // Un metodo para cada tipo de elemento
        
        // Hojas
        void Visitar(Elemento pElemento);

        // Raiz de nuevo sub-arbol
        void Visitar(ElementoL pElemento);
    }
}
