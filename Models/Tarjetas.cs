namespace CajeroApp.Models
{
    public class Tarjeta
    {
        public string Numero { get; set; }
        public string Titular { get; set; }
        public string PIN { get; set; }
        public decimal Saldo { get; set; }
        public bool Activa { get; set; }

        public Tarjeta(string numero, string titular, string pin, decimal saldo)
        {
            Numero = numero;
            Titular = titular;
            PIN = pin;
            Saldo = saldo;
            Activa = true;
        }

        public bool ValidarPIN(string pinIngresado)
        {
            return Activa && PIN == pinIngresado;
        }

        public bool Retirar(decimal monto)
        {
            if (monto > 0 && Saldo >= monto)
            {
                Saldo -= monto;
                return true;
            }
            return false;
        }

        public void Depositar(decimal monto)
        {
            if (monto > 0)
                Saldo += monto;
        }
    }
}
