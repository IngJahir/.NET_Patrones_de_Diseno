using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class BuilderNormal : IBuilder
    {
        private Producto auto = new Producto();

        public void ConstrulleCarroceria()
        {
            auto.ColocarCarroceria(new CarroceriaBasica());
        }

        public void ConstrulleLlantas()
        {
            auto.ColocarLlantas(new llatas12());
        }

        public void ConstrulleMotor()
        {
            auto.ColocarMotor(new MotorBasico());
        }

        public Producto ObtenProducto() 
        {
            return auto;
        }
    }
}
