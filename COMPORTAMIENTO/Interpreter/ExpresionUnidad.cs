using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    class ExpresionUnidad:Expresion
    {
        // Regresamos el caracter para que sea utilizado por el 
        // interprete para reconocer y evaluar el valor
        public override string Unidad() { return "I"; }
        public override string Cuatro() { return "IV";}
        public override string Cinco() { return "V"; }        
        public override string Nueve() { return "IX"; }

        // El valor encontrado sera multiplicado por 1
        // en el interprete
        public override int Factor() { return 1; }
    }
}
