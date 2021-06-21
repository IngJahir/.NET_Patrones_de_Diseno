using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    interface IColega
    {
        void Recibir(string emisor, string mensaje);
        void Enviar(string mensaje);
    }
}
