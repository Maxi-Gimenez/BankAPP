using CajeroApp.Interfaces;
using CajeroApp.Services;
using CajeroApp.Models;

namespace CajeroApp.Logic
{
    public class CajeroLogica
    {
        public void Iniciar()
        {
            InterfazConsola.MostrarInsertar();
            Console.ReadKey();
            InterfazConsola.MostrarOpcionesTarjetas();
            Console.Write("> ");
            string TarjetaElegida = Console.ReadLine();



            while (true)
            {
                string input = PantallaService.LeerInput("Ingrese clave:");

                if (input.Length != 4)
                {
                    PantallaService.MostrarMensaje("El PIN debe tener exactamente 4 dígitos", ConsoleColor.Red);
                    Console.ReadKey();
                    continue;
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("> ");
                Console.ResetColor();

                string comando = Console.ReadLine().ToLower();

                if (comando == "aceptar")
                {
                    InterfazConsola.MostrarInicio();
                    InterfazConsola.MostrarMenu();

                    Console.Write("> ");
                    string opcionMenu = Console.ReadLine().ToLower();
                    break;
                }
                else if (comando == "cancelar")
                {
                    Environment.Exit(0);
                }
            }
        }

        public void ListaTarjetas()
        {
            List<Tarjeta> tarjetas = new List<Tarjeta>
            {
                new Tarjeta("4556737586899855", "Ana López", "5678", 3000),
                new Tarjeta("4716952365783294", "Carlos Torres", "0123", 10000),
                new Tarjeta("4539148803436467", "Jorge Florencio", "1625", 500),
                new Tarjeta("4916732487531289", "Lucia Brignolo", "2089", 250)
            };

            // Llamamos a la función MostrarNombre pasando el nombre de la primera tarjeta
            InterfazConsola.MostrarNombre(tarjetas[0].Titular);
        }
    }
}
