using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------------
            // Proxy sencillo 
            // ---------------            
            CProxy.ISujeto miProxy = new CProxy.ProxySencillo();

            // No podemos acceder a la clase CProxy.CCocina por que esta anidada en CProxy
            // CProxy.CCocina

            Console.WriteLine("--------------");
            Console.WriteLine("PROXY SENCILLO");
            Console.WriteLine("--------------");
            miProxy.Peticion(1);
            Console.WriteLine("-----");
            miProxy.Peticion(2);
            Console.WriteLine(" ");

            // -------------
            // Proxy seguro
            // -------------
            CProxy.ISujeto miProxyS = new CProxy.ProxySeguro();

            Console.WriteLine("------------");
            Console.WriteLine("PROXY SEGURO");
            Console.WriteLine("------------");
            miProxyS.Peticion(1);
            Console.WriteLine("-----");
            miProxyS.Peticion(2);
            Console.WriteLine("-----");
        }
    }
}
