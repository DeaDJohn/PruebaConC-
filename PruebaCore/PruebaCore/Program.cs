using System;

namespace PruebaCore
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensaje2;

            Console.WriteLine("Hello World! ");
            WriteConsole("Por favor escribe su nombre");
            string mensaje1 = ReadConsole();
            if (string.IsNullOrEmpty(mensaje1))
            {
                WriteConsole("Por favor escribe su nombre");
                mensaje1 = ReadConsole();
            }
            else
            {
                WriteConsole("Por favor escribe su apellido");
                mensaje2 = ReadConsole();
                if (string.IsNullOrEmpty(mensaje2))
                {

                    WriteConsole("Por favor escribe su apellido");
                    mensaje2 = ReadConsole();
                }
                else
                {
                    string mensajeMostrar = String.Format("Tu nombre es {0} {1}", mensaje1, mensaje2);
                    WriteConsole(mensajeMostrar);
                    Console.ReadKey();
                }
            }
            
            
        }

        static string ReadConsole()
        {
            string mensajeEscrito = Console.ReadLine();
            return mensajeEscrito;
        }
        static void WriteConsole(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
