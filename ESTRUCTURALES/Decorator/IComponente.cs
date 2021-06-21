using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    // Usaremos esta interfaz para la decoracion 
    public interface IComponente
    {
        double Costo();
        string Funciona();        
    }
}
