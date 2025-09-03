using System;
    internal class Septiembre3
{
    static void Main(string[] args)
    {
        int numero;
        Random rnd = new Random();
        numero = rnd.Next(2, 101);//Devuelve un número entre 1 y 100
        int numerousuario = 0;
        Console.WriteLine("Ingrese un numero del 1 al 100");
        numerousuario =Int32.Parse(Console.ReadLine());
        while ( numerousuario != numero)
        {
            if ( numerousuario > numero )
            {
                Console.WriteLine("El numero que escogiste es muy grande");
            }
            else
            {
                Console.WriteLine("El numero que escogiste es muy pequeno");
            }
            Console.WriteLine("Intenta otra vez");
            numerousuario = Int32.Parse(Console.ReadLine());
        }
        Console.WriteLine("Adivinaste el numero");
    }
}
