namespace CajeroApp.Services
{
    public static class PantallaService
    {
        public static void Pantalla(string titulo, string input = "")
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            string lineaTitulo = $"|{titulo.PadLeft((titulo.Length + 43) / 2).PadRight(43)}|";
            string lineaInput = $"|{input.PadLeft((input.Length + 43) / 2).PadRight(43)}|";

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("|                                           |");
            Console.WriteLine("|                                           |");
            Console.WriteLine(lineaTitulo);
            Console.WriteLine(lineaInput);
            Console.WriteLine("|                                           |");
            Console.WriteLine("|                                           |");
            Console.WriteLine("---------------------------------------------");

            Clave();
            Console.ResetColor();
        }

        public static string LeerInput(string prompt)
        {
            string input = "";
            Console.Clear();
            Console.WriteLine(prompt);

            while (true)
            {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter) break;

                if (key.Key == ConsoleKey.Backspace && input.Length > 0)
                    input = input[..^1];
                else if (!char.IsControl(key.KeyChar) && char.IsDigit(key.KeyChar))
                    input += key.KeyChar;

                Pantalla("BANCO APP", new string('*', input.Length));
            }

            return input;
        }

        public static void MostrarMensaje(string mensaje, ConsoleColor color)
        {
            Console.Clear();
            Console.ForegroundColor = color;
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("|                                           |");
            Console.WriteLine("|                                           |");
            Console.WriteLine($"|{mensaje.PadLeft((mensaje.Length + 43) / 2).PadRight(43)}|");
            Console.WriteLine("|                                           |");
            Console.WriteLine("|                                           |");
            Console.WriteLine("---------------------------------------------");
            Console.ResetColor();
        }

        public static void Clave()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("|      1      |      2      |      3      |");
            Console.WriteLine("|      4      |      5      |      6      |");
            Console.WriteLine("|      7      |      8      |      9      |");
            Console.WriteLine("|    ACEPTAR  |      0      |   CANCELAR  |");
            Console.WriteLine("---------------------------------------------");
            Console.ResetColor();
        }
    }
}
