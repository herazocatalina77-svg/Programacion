using System;
namespace _23.Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //Arreglos Unidimensionales
                //Vectores
                int[] numeros = new int[5]; //Elvectornumero tiene 5 posiciones
                string[] nombres = new string[4];
                //Asignar valores a las posiciones
                numeros[0] = 20;
                numeros[1] = 15;
                numeros[2] = 5;
                numeros[3] = 30;
                numeros[4] = 45;
                //vectores inicializados por defecto
                int[] numeros1 = new int[] { 1, 2, 3, 4, 5 };
                int[] numeros2 = { 5, 12, 4, 7, 9 };
                char[] caracter = new char[4];
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Ingrese el caracter para la posicion {i + 1}, con indice {i}:");
                    caracter[i]=Convert.ToChar(Console.ReadLine());
                }
                Console.WriteLine($"El vector caracter, en la posición 3, tiene almacenado el dato{caracter[2]}");
                for ( int i = 0; i < caracter.Length; i++)
                {
                    Console.WriteLine("\n" + caracter[i] + "|");
                }
                for (int i = 'A'; i < 5;)
                {

                }

            }
        }
    }
}
