using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    class ExpresionDecenas : Expresion
    {
        // Regresamos el caracter para que sea utilizado por el 
        // interprete para reconocer y evaluar el valor
        public override string Unidad() { return "X"; }        
        public override string Cuatro() { return "XL"; }
        public override string Cinco() { return "L"; }
        public override string Nueve() { return "XC"; }
        
        // El valor encontrado sera multiplicado por 10
        // en el interprete
        public override int Factor() { return 10; }
        
    }
}
