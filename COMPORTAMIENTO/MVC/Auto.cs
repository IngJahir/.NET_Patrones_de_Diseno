using System;
using System.Collections.Generic;
using System.Text;

namespace MVC
{   
    // Esta clase representa al modelo
    // -------------------------------
    class Auto
    {
        private string nombre;
        private int modelo;
        private double costo;

        public Auto(string pNombre, int pModelo, double pCosto) 
        {
            nombre = pNombre;
            modelo = pModelo;
            costo = pCosto;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Modelo { get => modelo; set => modelo = value; }
        public double Costo { get => costo; set => costo = value; }
    }
}
