using System;
    namespace tikiti
{
    internal class Repe
    {
        static void Main (string[] args)
        {
            int contador = 0;
            int acumulador = 0;
            while (contador <= 5)
            {
                acumulador += contador;
                Console.WriteLine($"Contador: {contador} - acumulador {acumulador}");
                contador++;
            }
            Console.WriteLine ("La suma de los primeros cinco numeros enteros  es" + acumulador);
        }
    }
}
