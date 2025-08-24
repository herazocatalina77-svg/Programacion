// See https://aka.ms/new-console-template for more information

public class Clasetrecedeagosto
{
    static void Main(string[] args)
    {
        string nombre = "";
        int sueldo = 0;
        Console.WriteLine("Ingrese el nombre");
        nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el sueldo");
        sueldo = Int32.Parse(Console.ReadLine());
        if (sueldo > 3000)
        {
            //Verdadero
            Console.WriteLine($"La persona {nombre} , debe abonar impuestos");
        }
        else
        {
            //False
            Console.WriteLine($"La persona {nombre} , no abona impuestos");
        }
    }
    static void Second(string[] args)
    {
        int edad = 0;
        Console.WriteLine("Ingrese edad");
        edad = Int32.Parse(Console.ReadLine());
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
        int num1 = 0;
        Console.WriteLine("Ingrese numero1");
        num1 = Int32.Parse(Console.ReadLine());
        int num2 = 0;
        Console.WriteLine("Ingrese numero2");
        num2 = Int32.Parse(Console.ReadLine());
        if (num2 < num1)
        {
            //Verdadero
            Console.WriteLine($"Suma");
            int num3 = num1 + num2;
            Console.WriteLine(num3);
            Console.WriteLine($"Resta");
            int num4 = num1 - num2;
            Console.WriteLine(num4);
        }
        else
        {
            int num5 = num1 * num2;
            Console.WriteLine(num5);
            int num6 = num1 / num2;
            Console.WriteLine(num6);
        }
    }
    static void Fourth(string[] args)
    {
        string nombre= "";
        Console.WriteLine($"Ingrese el nombre");
        nombre = (Console.ReadLine());
        int num1 = 0;
        Console.WriteLine($"Ingrese la cantidad de noches que se va a quedar");
        num1 = Int32.Parse(Console.ReadLine());
        if (num1 > 3)
        {
            Console.WriteLine($"El precio total de su hospedaje sera");
            double num2 = num1 * 200;
            double num3 = num2 * 0.83;
            Console.WriteLine(num3);
        }
        else
        {
            Console.WriteLine($"El precio total de su hospedaje sera");
            double num4 = num1 * 200;
            double num5 = num4 * 0.88;
            Console.WriteLine(num5);
        }
    }
}
   