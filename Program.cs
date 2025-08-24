// See https://aka.ms/new-console-template for more information

public class Program
{
    static void Main(string[] args)
    {
        string nombre = "";
        int sueldo = 0;
        Console.WriteLine("Ingrese el nombre");
        nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el sueldo");
        sueldo = Int32.Parse(Console.ReadLine());
        if (sueldo < 3000)
        {
            //Verdadero
            Console.WriteLine($"La persona (nombre), debe abonar impuestos");
        }
        else
        {
            //False
            Console.WriteLine($"La persona (nombre), no abona impuestos");
        }
    }
    static void Second(string[] args)
    {
        int edad = 0;
        Console.WriteLine("Ingrese edad");
        if (edad < 18)
        {
            //Verdadero
            Console.WriteLine("Bienvenido al sitio web");
        }
        else
        {
            //falso
            Console.WriteLine("No es apto para este sitio web");
        }
    } 
    static void Third(string[] args)
    {
        int num = 0;
    }
}