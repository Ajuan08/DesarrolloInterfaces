namespace monedas.cs
{
    internal class Program
    {
        static void Main(string[] args)
        /*
        {
            Console.WriteLine("Introduce el dinero");

            const double precio = 0.45;
            const double cinco = 0.05;
            const double diez = 0.10;
            const double veinte = 0.20;
            const double cincuenta = 0.50;
            const double euro = 1.00;
            const double dosEuros = 2.00;

            string dinero = Console.ReadLine();

            int dinero_int = Convert.ToInt32(dinero);
            double dinero_double = Convert.ToDouble(dinero_int);

            double resto = dinero_int - precio;
        }
    }
        */

        {
            int precioProducto = 45;

            Console.Write("Introduce la cantidad en céntimos: ");
            int cantidadIntroducida = Convert.ToInt32(Console.ReadLine());

            int cambio = cantidadIntroducida - precioProducto;

            
                int[] valoresMonedas = { 200, 100, 50, 20, 10, 5 };

                
        }
    }
}