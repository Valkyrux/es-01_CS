using System;

namespace myApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prodotto tra due numeri da input:");
            int v1, v2;

            Console.WriteLine("Inserisci il primo numero");
            while (!int.TryParse(Console.ReadLine(), out v1))
            {
                Console.WriteLine("Numero non valido, reiserire il primo numero");
            }

            Console.WriteLine("Inserisci il secondo numero");
            while (!int.TryParse(Console.ReadLine(), out v2))
            {
                Console.WriteLine("Numero non valido, reiserire il secondo numero");
            }

            Console.WriteLine("Il risultato: {0}", multiply(v1, v2));

        }
        //multiply function
        static int multiply(int a, int b)
        {
            return a * b;
        }
    }
}