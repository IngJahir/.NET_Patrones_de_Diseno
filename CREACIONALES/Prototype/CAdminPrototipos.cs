using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class CAdminPrototipos
    {
        // Se emplea un diccionaro para identificar el prototipo por una cadena
        // --------------------------------------------------------------------
        private Dictionary<string, IPrototipo> prototipos = new Dictionary<string, IPrototipo>();

        public CAdminPrototipos() 
        {
            // Adiciona los objetos prototipo con los valores iniciales que nos interesan

            CPersona persona = new CPersona("Ciudadano", 18);
            prototipos.Add("Persona", persona);

            CValores valores = new CValores(1);
            prototipos.Add("Valores",valores);
        }

        public void AdicionaPrototipo(string pLlave, IPrototipo pPrototipo) 
        {
            prototipos.Add(pLlave, pPrototipo);
        }

        public object ObtenPrototipo(string pLlave) 
        {
            return prototipos[pLlave].Clonar();
        }
    }
}
