using System;

namespace Builder
{
    interface IBuilder
    {
        // Acciones que va a llevar cabo
        // -----------------------------
        void ConstrulleMotor();
        void ConstrulleCarroceria();
        void ConstrulleLlantas();
    }
}
