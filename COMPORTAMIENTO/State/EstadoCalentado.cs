using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class EstadoCalentado : IEstado
    {
        // Referencia a la caldera
        Caldera miCaldera;

        public EstadoCalentado(Caldera pCaldera)
        {
            miCaldera = pCaldera;
        }

        public void Trabajar()
        {
            if (miCaldera.Combustible > 0) 
            {
                Console.WriteLine("Estamos calentando");
                miCaldera.Combustible -= 3;
                miCaldera.Temperatura += 10;
            }

            // Verificamos si hay cambio de estado
            if (miCaldera.Temperatura > 100)
                miCaldera.ColocarEstado(miCaldera.Alarma);
            else if (miCaldera.Temperatura > 80)
                miCaldera.ColocarEstado(miCaldera.Espera);

            if (miCaldera.Combustible <= 0)
                miCaldera.ColocarEstado(miCaldera.Espera);

        }

        public void CortarFuego()
        {
            Console.WriteLine("Cortamos fuego");
            miCaldera.ColocarEstado(miCaldera.Espera);
        }

        public void PonerCombustible()
        {
            Console.WriteLine("No se puede colocar combustible cuando esta prendida");
        }

        public void ForzarFuego()
        {
            Console.WriteLine("El fuego ya esta prendido");
        }

        public override string ToString()
        {
            return string.Format("Calentado -> temp {0}, comb {1}", miCaldera.Temperatura, miCaldera.Combustible);
        }
    }
}
