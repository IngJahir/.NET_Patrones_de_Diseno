using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    class CareTaker
    {
        private Memento memento;

        public Memento Memento { get => memento; set => memento = value; }

    }
}
