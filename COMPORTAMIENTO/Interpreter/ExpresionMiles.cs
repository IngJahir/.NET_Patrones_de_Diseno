using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    class ExpresionMiles:Expresion
    {
        // Regresamos el caracter para que sea utilizado por el 
        // interprete para reconocer y evaluar el valor
        public override string Unidad() { return "M"; }
        public override string Cuatro() { return " "; }
        public override string Cinco() { return " "; }
        public override string Nueve() { return " "; }

        // El valor encontrado sera multiplicado por 10
        // en el interprete
        public override int Factor() { return 1000; }
    }
}
