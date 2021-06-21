using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    interface IObservador
    {
        void Update(string mensaje);
        void UpdatePull();
    }
}
