using System;
namespace Parcialciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double notas = 0;
            int cantidadestudiantes = 0;
            double sumanotas = 0;
            string todasNotas = "";
            while (cantidadestudiantes < 15)
            {
                Console.WriteLine("Ingrese su nota ");
                notas = Convert.ToDouble(Console.ReadLine());
                sumanotas += notas; //La suma de todas las notas de los estudiantes
                todasNotas += notas + "\n";
                cantidadestudiantes++;
            if (0 < notas || notas > 5)
            {
                if (notas <= 2.9)
                {
                    Console.WriteLine("Sus notas fueron insuficientes");
                }
                else if (notas <= 3 || notas <= 3.9)
                {
                    Console.WriteLine("Sus notas fueron regulares");
                }
                else if (notas <= 4 || notas <= 4.7)
                {
                    Console.WriteLine("Sus notas fueron buenas");
                }
                else
                {
                    Console.WriteLine("Sus notas fueron excelentes");
                }

            }
            }
            double promedio = sumanotas / cantidadestudiantes;
            //En cuanto todos los estudiantes escriban sus notas, el ciclo se rompe
            //Calculo del promedio
            Console.WriteLine($"El promedio de los estudiantes fue de:{promedio} ");//Escribe el promedio de los estudiantes 
            //Mostrar las notas de todos los estudiantes
            Console.WriteLine($"Las notas fueron: {todasNotas}");

        }
    }
}