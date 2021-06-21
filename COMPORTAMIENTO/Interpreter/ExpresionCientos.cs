using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    class ExpresionCientos : Expresion
    {
        // Regresamos el caracter para que sea utilizado por el 
        // interprete para reconocer y evaluar el valor
        public override string Unidad() { return "C"; }
        public override string Cuatro() { return "CD"; }
        public override string Cinco() { return "D"; }
        public override string Nueve() { return "CM"; }

        // El valor encontrado sera multiplicado por 10
        // en el interprete
        public override int Factor() { return 100; }
    }
}
