using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class BuilderDeportivo : IBuilder
    {
        private Producto auto = new Producto();

        public void ConstrulleCarroceria()
        {
            auto.ColocarCarroceria(new CarroceriaEspecial());
        }

        public void ConstrulleLlantas()
        {
            auto.ColocarLlantas(new LlantasSuper());
        }

        public void ConstrulleMotor()
        {
            auto.ColocarMotor(new MotorGrande());
        }

        public Producto ObtenProducto() 
        {
            return auto;
        }
    }
}
