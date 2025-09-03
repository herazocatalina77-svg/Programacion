using System;
internal class Sep3clase3
{
    static void Main(string[] args)
    {
        // Algoritmo que cuente cuantos numeros pares hay en un rango del 1 al numero n
        int rango = 0;
        int contadorPares = 0;
        int contador = 1;
        Console.WriteLine("Ingrese el rango a evaluar");
        rango=int.Parse(Console.ReadLine());
        while (contador<=rango)
        {
            if (contador % 2 == 0)
            {
                contadorPares++;
            }
            contador++;
        }
        Console.WriteLine($"La cantidad de numeros pares de 1 hasta {rango} es: {contadorPares}");
    }
}
