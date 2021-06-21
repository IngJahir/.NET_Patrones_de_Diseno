using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class Caldera
    {
        // Variables de referencia a los estados
        private IEstado calentado;
        private IEstado alarma;
        private IEstado espera;

        // Esta variable representa al estado actual
        private IEstado estado;

        private int temperatura;
        private int combustible;

        public int Temperatura { get => temperatura; set=> temperatura = value; }
        public int Combustible { get => combustible; set => combustible = value; }
        internal IEstado Calentado { get => calentado; set => calentado = value; }
        internal IEstado Alarma { get => alarma; set => alarma = value; }
        internal IEstado Espera { get => espera; set => espera = value; }


        public Caldera()
        {
            temperatura = 20;
            combustible = 50;

            // Instanciamos los estados
            calentado = new EstadoCalentado(this);
            alarma = new EstadoAlarma(this);
            espera = new EstadoEspera(this);

            estado = calentado;
        }

        public void ColocarEstado(IEstado pEstado) 
        {
            Console.WriteLine("--- Cambio de estado ----");
            estado = pEstado;
        }

        public void Trabajar() 
        {
            estado.Trabajar();
        }

        public void CortarFuego() 
        {
            estado.CortarFuego();
        }

        public void PonerCombustible() 
        {
            estado.PonerCombustible();
        }

        public void ForzarFuego() 
        {
            estado.ForzarFuego();
        }

        public override string ToString()
        {
            return estado.ToString();
        }
    }
}
