using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil miAuto = new Automovil();
            ControlRemoto control = new ControlRemoto(miAuto);
            string opcion;

            do
            {
                Console.WriteLine("1-Encender, 2-Apagar, 3-Prender alarma, 4-Apagar alarma, 5-Salir");
                opcion = Console.ReadLine();

                if (opcion == "1")
                    control.Boton(0);
                if (opcion == "2")
                    control.Boton(1);
                if (opcion == "3")
                    control.Boton(2);
                if (opcion == "4")
                    control.Boton(3);

            } while (opcion !="5");
        }
    }
}
