using System;
public class Parcialcondicionales
{
    static void Main(string[] args)
    {
        //Hola profe, yo sé que el tiempo de parcial ya pasó, pero la verdad por falta de tiempo, algunas variables quedaron como no eran, así que me tome la libertad de terminar el trabajo para corregir las cosas que no pude durante el tiempo del parcial, independientemente si esto puede ayudar de algo a mi nota o no
        Console.WriteLine("Bienvenido a la pizzeria Olafo, lugar para crear pizzas personalizadas");
        Console.WriteLine("Ingrese V si quiere una pizza vegetariana, en el caso de que no ingrese N");
        char letra = Console.ReadLine()[0];
        if (letra == 'V' || letra == 'v') //Pizza vegetariana
        {
            Console.WriteLine("Las opciones de ingredientes para pizza vegetariana son: 1)Pimiento, 2)Tofu, 3)Champiñones, 4)Tomate, 5)Lechuga");
            Console.WriteLine("Ingrese el primer ingrediente, en base al numero asignado en el ingrediente");
            int numingrediente1 = 0;
            numingrediente1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo ingrediente, en base al numero asignado en el ingrediente, si no quiere seguir agregando ingredientes, ingrese el numero 7");
            int numingrediente2 = 0;
            numingrediente2 = Int32.Parse(Console.ReadLine());
            if (numingrediente2 != 7)
            {
                Console.WriteLine("Ingrese el tercer ingrediente, en base al numero asignado en el ingrediente, si no quiere seguir agregando ingredientes, ingrese el numero 8");
                int numingrediente3 = 0;
                numingrediente3 = Int32.Parse(Console.ReadLine());
                if (numingrediente3 != 8)
                {
                    Console.WriteLine("Ingrese el cuarto ingrediente, en base al numero asignado en el ingrediente, si no quiere seguir agregando ingredientes, ingrese el numero 9");
                    int numingrediente4 = 0;
                    numingrediente4 = Int32.Parse(Console.ReadLine());
                    if (numingrediente4 != 9)
                    {
                        Console.WriteLine("Ingrese el quinto ingrediente, en base al numero asignado en el ingrediente, si no quiere seguir agregando ingredientes, ingrese el numero 0");
                        int numingrediente5 = 0;
                        numingrediente5 += Int32.Parse(Console.ReadLine());
                        if (numingrediente5 != 9)
                        {
                            //Muestre el precio de los cinco ingredientes
                            double precio1 = 25000;
                            double precio2 = 25000 * 0.10;
                            double precio39 = precio2 + precio1;
                            Console.WriteLine($"El precio de su pizza es {precio39}");
                        }
                        else
                        {
                            //Muestra el precio de los cuatro ingredientes anteriores
                            double precio1 = 25000;
                            double precio2 = 25000 * 0.10;
                            double precio39 = precio2 + precio1;
                            Console.WriteLine($"El precio de su pizza es {precio39}");
                        }
                    }
                    else
                    {
                        //Muestre el precio de los tres ingredientes anteriores
                        switch (numingrediente1, numingrediente2, numingrediente3)
                        {
                            case var (a, b, c) when (a == 1 && b == 3 && c == 5):
                                double precio3 = 20000;
                                double precio4 = precio3 * 0.19;
                                double precio47 = precio4 + precio3;
                                Console.WriteLine($"El precio de su pizza será {precio47}");
                                break;
                            case var (a, b, c) when (a == 3 && b == 1 && c == 5):
                                double precio5 = 20000;
                                double precio6 = precio5 * 0.19;
                                double precio48 = precio5 + precio6;
                                Console.WriteLine($"El precio de su pizza será {precio48}");
                                break;
                            case var (a, b, c) when (a == 5 && b == 1 && c == 3):
                                double precio7 = 20000;
                                double precio8 = precio7 * 0.19;
                                double precio49 = precio7 + precio8;
                                Console.WriteLine($"El precio de su pizza será {precio8}");
                                break;
                            case var (a, b, c) when (a == 1 && b == 5 && c == 3):
                                double precio9 = 20000;
                                double precio10 = precio9 * 0.19;
                                double precio50 = precio9 + precio10;
                                Console.WriteLine($"El precio de su pizza será {precio50}");
                                break;
                            case var (a, b, c) when (a == 3 && b == 5 && c == 1):
                                double precio11 = 20000;
                                double precio12 = precio11 * 0.19;
                                double precio51 = precio11 + precio12;
                                Console.WriteLine($"El precio de su pizza será {precio51}");
                                break;
                            case var (a, b, c) when (a == 2 && b == 5 && c == 3):
                                double precio13 = 20000;
                                double precio14 = precio13 * 0.19;
                                double precio52 = precio13 + precio14;
                                Console.WriteLine($"El precio de su pizza será {precio52}");
                                break;
                            case var (a, b, c) when (a == 3 && b == 2 && c == 5):
                                double precio15 = 30000;
                                double precio16 = precio15 * 0.15;
                                double precio53 = precio15 + precio16;
                                Console.WriteLine($"El precio de su pizza será {precio53}");
                                break;
                        }

                    }
                }
                else
                {
                    //Muestre el precio de los dos ingredientes anteriores
                    double precio1 = 25000;
                    double precio2 = 25000 * 0.10;
                    double precio39 = precio2 + precio1;
                    Console.WriteLine($"El precio de su pizza es {precio39}");
                }

            }
            else
            {
                //Muestre el precio del primer ingrediente
                double precio1 = 25000;
                double precio2 = 25000 * 0.10;
                double precio39 = precio2 + precio1;
                Console.WriteLine($"El precio de su pizza es {precio39}");
            }
        }
        else if (letra == 'N' || letra == 'n') //pizza de carnes
        {
            Console.WriteLine("Las opciones para pizza NO vegetariana son: 1)Res, 2)Chorizo, 3)Pollo, 4)Tocineta, 5)Cerdo");
            Console.WriteLine("Ingrese el primer ingrediente, en base al numero asignado en el ingrediente");
            int numingrediente6 = 0;
            numingrediente6 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo ingrediente, en base al numero asignado en el ingrediente, si no quiere seguir agregando ingredientes, ingrese el numero 7");
            int numingrediente7 = 0;
            numingrediente7 = Int32.Parse(Console.ReadLine());
            if (numingrediente6 != 7)
            {
                Console.WriteLine("Ingrese el tercer ingrediente, en base al numero asignado en el ingrediente, si no quiere seguir agregando ingredientes, ingrese el numero 8");
                int numingrediente8 = 0;
                numingrediente8 = Int32.Parse(Console.ReadLine());
                if (numingrediente8 != 8)
                {
                    Console.WriteLine("Ingrese el cuarto ingrediente, en base al numero asignado en el ingrediente, si no quiere seguir agregando ingredientes, ingrese el numero 9");
                    int numingrediente9 = 0;
                    numingrediente9 = Int32.Parse(Console.ReadLine());
                    if (numingrediente9 != 9)
                    {
                        Console.WriteLine("Ingrese el quinto ingrediente, en base al numero asignado en el ingrediente, si no quiere seguir agregando ingredientes, ingrese el numero 0");
                        int numingrediente10 = 0;
                        numingrediente10 = Int32.Parse(Console.ReadLine());
                        if (numingrediente10 != 9)
                        {
                            //Muestre el precio de los cinco ingredientes
                            double precio17 = 22000;
                            double precio18 = precio17 * 0.10;
                            double precio40 = precio17 + precio18;
                            Console.WriteLine($"El precio de su pizza es {precio40}");
                        }
                        else
                        {
                            //Muestra el precio de los cuatro ingredientes anteriores
                            double precio19 = 22000;
                            double precio20 = precio19 * 0.10;
                            double precio40 = precio20 + precio19;
                            Console.WriteLine($"El precio de su pizza es {precio40}");
                        }
                    }
                    else
                    {
                        //Muestre el precio de los tres ingredientes anteriores
                        double precio23 = 22000;
                        double precio24 = precio23 * 0.10;
                        double precio40 = precio23 + precio24;
                        Console.WriteLine($"El precio de su pizza es {precio40}");
                    }
                }
                else
                {
                    //Muestre el precio de los dos ingredientes anteriores
                    switch (numingrediente6, numingrediente7)
                    {
                        case var (a, b) when (a == 1 && b == 3):
                            double precio25 = 10000;
                            double precio26 = precio25 * 0.19;
                            double precio41 = precio26 + precio25;
                            Console.WriteLine($"El precio de su pizza será {precio41}");
                            break;
                        case var (a, b) when (a == 3 && b == 1):
                            double precio27 = 10000;
                            double precio28 = precio27 * 0.19;
                            double precio42 = precio27 + precio28;
                            Console.WriteLine($"El precio de su pizza será {precio42}");
                            break;
                        case var (a, b) when (a == 4 && b == 1):
                            double precio29 = 20000;
                            double precio30 = precio29 * 0.19;
                            double precio43 = precio29 + precio30;
                            Console.WriteLine($"El precio de su pizza será {precio43}");
                            break;
                        case var (a, b) when (a == 1 && b == 4):
                            double precio31 = 15000;
                            double precio32 = precio31 * 0.17;
                            double precio44 = precio31 + precio32;
                            Console.WriteLine($"El precio de su pizza será {precio44}");
                            break;
                        case var (a, b) when (a == 2 && b == 4):
                            double precio33 = 15000;
                            double precio34 = precio33 * 0.17;
                            double precio45 = precio33 + precio34;
                            Console.WriteLine($"El precio de su pizza será {precio45}");
                            break;
                        case var (a, b) when (a == 4 && b == 2):
                            double precio35 = 25000;
                            double precio36 = precio35 * 0.09;
                            double precio46 = precio35 + precio36;
                            Console.WriteLine($"El precio de su pizza será {precio46}");
                            break;
                    }
                }

            }
            else
            {
                //Muestre el precio del primer ingrediente
                double precio21 = 22000;
                double precio22 = 22000 * 0.10;
                double precio40 = precio22 + precio21;
                Console.WriteLine($"El precio de su pizza es {precio40}");
            }
        }
        else //Agregó una letra que no es ni V, ni N
        {
            Console.WriteLine("Solo existe la opción de Pizza Vegetariana(V) y Pizza No vegetariana (N)");
        }
    }
}  