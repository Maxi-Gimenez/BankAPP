using CajeroApp.Logic;

namespace CajeroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var cajero = new CajeroLogica();
            cajero.Iniciar();
        }
    }
}
