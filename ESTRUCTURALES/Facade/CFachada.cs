using System;
using System.Collections.Generic;
using System.Text;

// Es este caso hay un namesapce propio en donde aparecen los subsistemas
// ----------------------------------------------------------------------
namespace Subsistemas
{
    class CFachada
    {
        // Estos son los subsistemas que se estan utilizando
        private CSistemaCompra compra = new CSistemaCompra();
        private CSubsitemaAlmacen almacen = new CSubsitemaAlmacen();
        private CSubsistemaEnvio envio = new CSubsistemaEnvio();

        // ****************
        // Metodos publicos
        // ****************

        // Este metodo es usado para realizar de forma sencilla una operacion 
        // mas compleja que requiere de uno o varios subsistemas
        public void Compra() 
        {
            if (compra.Comprar()) 
            {
                if (almacen.SacarAlmacen())
                {
                    envio.EnviarPedido();
                }
            }            
        }
    }
}
