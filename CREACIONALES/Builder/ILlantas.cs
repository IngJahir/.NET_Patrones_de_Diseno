using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    interface ILlantas
    {
        string informacion();
    }

    class llatas12 : ILlantas
    {
        public string informacion()
        {
            return "Lantas de 14 pulgadas";
        }
    }

    class LlantasSuper : ILlantas
    {
        public string informacion()
        {
            return "Lantas de 18 `pulgadas, rines aluminio";
        }
    }
}
