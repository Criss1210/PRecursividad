namespace PracticaRecursividadSumaDigitos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un número natural: ");
            int numero = int.Parse(Console.ReadLine());

            int sumaRecursiva = SumarDigitosRecursivo(numero);
            int sumaIterativa = SumarDigitosIterativo(numero);

            Console.WriteLine($"\nSuma de dígitos (recursiva): {sumaRecursiva}");
            Console.WriteLine($"Suma de dígitos (iterativa): {sumaIterativa}");
        }

        // Método recursivo
        static int SumarDigitosRecursivo(int n)
        {
            if (n < 10)
                return n;
            else
                return (n % 10) + SumarDigitosRecursivo(n / 10);
        }

        // Método iterativo
        static int SumarDigitosIterativo(int n)
        {
            int suma = 0;
            while (n > 0)
            {
                suma += n % 10;
                n /= 10;
            }
            return suma;
        }
    }
}
