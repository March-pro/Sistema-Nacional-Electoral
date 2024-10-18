using System;

class Program
{
    static Random random = new Random();

    static void Main(string[] args)
    {
        Console.Write("Ingrese la cantidad de empleados: ");
        int X = int.Parse(Console.ReadLine());

        string[] nombres = new string[X];
        double[] sueldos = new double[X];

        generardatos(ref nombres, ref sueldos);
        double bonostotales = 0;

        while (true)
        {
            int empleadoseleccionado = empleados(nombres, sueldos);
            if (empleadoseleccionado == -1) break;

            bonostotales += bono(nombres[empleadoseleccionado], ref sueldos[empleadoseleccionado]);

            Console.Write("¿Desea seleccionar otro empleado? (s/n): ");
            if (Console.ReadLine().ToLower() != "s") break;
        }

        Console.WriteLine($"\nEl total de bonos acumulados es: {bonostotales:C2}");
    }

    static void generardatos(ref string[] nombres, ref double[] sueldos)
    {
        for (int i = 0; i < nombres.Length; i++)
        {
            nombres[i] = generarnombrealeatorio();
            sueldos[i] = random.NextDouble() * 1000;
        }
    }
    static string generarnombrealeatorio()
    {
        char[] nombre = new char[5];
        for (int i = 0; i < nombre.Length; i++)
        {
            nombre[i] = (char)random.Next('A', 'Z' + 1);
        }
        return new string(nombre);
    }
    static int empleados(string[] nombres, double[] sueldos)
    {
        Console.WriteLine("\nLista de empleados y sueldos:");
        for (int i = 0; i < nombres.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {nombres[i]} - {sueldos[i]:C2}");
        }

        Console.Write("\nSeleccione el número del empleado para darle un bono o escriba 'no' para salir: ");
        string opcion = Console.ReadLine().ToLower();

        if (opcion == "no")
        {
            return -1; 
        }
        else
        {
            int indice = int.Parse(opcion) - 1;
            if (indice >= 0 && indice < nombres.Length)
            {
                return indice;
            }
        }

        return -1; 
    }
    static double bono(string nombre, ref double sueldo)
    {
        Console.Write($"Ingrese el porcentaje de bono para {nombre} (0-100%): ");
        double porcentaje = double.Parse(Console.ReadLine()) / 100.0;
        double bono = sueldo * porcentaje;

        Console.WriteLine($"Bono para {nombre}: {bono:C2}");
        return bono;
    }
}
