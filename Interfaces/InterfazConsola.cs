using CajeroApp.Logic;
using CajeroApp.Models;

namespace CajeroApp.Interfaces
{
    public static class InterfazConsola
    {
        public static void MostrarInicio()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("|                                           |");
            Console.WriteLine("|                                           |");
            Console.WriteLine("|                 Banco APP                 |");
            Console.WriteLine("|                                           |");
            Console.WriteLine("|                                           |");
            Console.WriteLine("---------------------------------------------");
            Console.ResetColor();
        }

        public static void MostrarInsertar()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("|                                           |");
            Console.WriteLine("|                                           |");
            Console.WriteLine("|              Inserte la tarjeta...        |");
            Console.WriteLine("|                                           |");
            Console.WriteLine("|                                           |");
            Console.WriteLine("---------------------------------------------");
            Console.ResetColor();
        }

        public static void MostrarOpcionesTarjetas()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("|                                           |");
            Console.WriteLine("|      [1] [4556 7375 8689 9855]            |");
            Console.WriteLine("|      [2] [4716 9523 6578 3294]            |");
            Console.WriteLine("|      [3] [4539 1488 0343 6467]            |");
            Console.WriteLine("|      [4] [4916 7324 8753 1289]            |");
            Console.WriteLine("|                                           |");
            Console.WriteLine("---------------------------------------------");
            Console.ResetColor();
        }

        public static void MostrarMenu()
        {
            string retiro = "1000";
            string retiroTexto = $"$ {retiro}".PadRight(10);

            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.WriteLine($"| 1 - Extracción      | 5 - Retiro {retiroTexto} |");
            Console.WriteLine("| 2 - Depósitos       | 6 - Más servicios     |");
            Console.WriteLine("| 3 - Consultas       | 7 - Transferencia     |");
            Console.WriteLine("| 4 - Cambio de PIN   | 8 - Cancelar          |");
            Console.WriteLine("---------------------------------------------");

            Console.ResetColor();
        }
        public static void MostrarNombre(string nombre)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("|                                           |");
            Console.WriteLine($"|          Hola, {nombre.PadRight(29)}|");
            Console.WriteLine("|                                           |");
            Console.WriteLine("|                                           |");
            Console.WriteLine("|                                           |");
            Console.WriteLine("---------------------------------------------");
            Console.ResetColor();
        }
    }
}
