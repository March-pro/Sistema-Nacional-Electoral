using System;

class ProyectoCarreritas
{
    static Random random = new Random();

    static void Main(string[] args)
    {
        string nombreJugador = "";
        double balanceJugador = 0;

        datosIniciales(ref nombreJugador, ref balanceJugador);

        string[] competidores = cargarCompetidores();

        while (true)
        {
            titulo();
            string[] opciones = { "Ver Competidores", "Ir a la Pista", "Salir" };
            int opcion = menu(opciones);

            switch (opcion)
            {
                case 1:
                    verCompetidores(competidores);
                    break;
                case 2:
                    irALaPista(ref balanceJugador, nombreJugador, ref competidores);
                    break;
                case 3:
                    Console.WriteLine("¡Gracias por jugar!");
                    return;
            }
        }
    }

    static void datosIniciales(ref string nombre, ref double balance)
    {
        Console.Write("Ingrese su nombre: ");
        nombre = Console.ReadLine();

        Console.Write("Ingrese su balance inicial: ");
        balance = double.Parse(Console.ReadLine());
    }

    static string[] cargarCompetidores()
    {
        Console.Write("¿Desea ingresar los competidores manualmente? (s/n): ");
        string opcion = Console.ReadLine().ToLower();

        Console.Write("¿Cuántos competidores desea incluir?: ");
        int cantidad = int.Parse(Console.ReadLine());

        string[] competidores = new string[cantidad];

        if (opcion == "s")
        {
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"Ingrese el nombre del competidor {i + 1}: ");
                competidores[i] = Console.ReadLine();
            }
        }
        else
        {
            for (int i = 0; i < cantidad; i++)
            {
                competidores[i] = generarCompetidor();
            }
        }

        return competidores;
    }

    static string generarCompetidor()
    {
        string letras = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string nombre = $"{letras[random.Next(0, letras.Length)]}{letras[random.Next(0, letras.Length)]}{letras[random.Next(0, letras.Length)]}";
        int numero = random.Next(0, 100); // Número aleatorio entre 0 y 99.
        return $"#{numero:D2} - {nombre}";
    }

    static void verCompetidores(string[] competidores)
    {
        Console.WriteLine("Lista de competidores:");
        for (int i = 0; i < competidores.Length; i++)
        {
            Console.WriteLine($"{competidores[i]}");
        }
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void irALaPista(ref double balance, string nombreJugador, ref string[] competidores)
    {
        string[] opcionesPista = { "Competir", "Espectar", "Volver" };
        int opcionPista = menu(opcionesPista);

        if (opcionPista == 1)
        {
            if (balance < 1000)
            {
                print("No tienes suficiente balance para competir. Necesitas al menos $1000.", 'r');
                Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
                Console.ReadKey();
                return;  // Regresa al menú sin permitir competir.
            }

            balance -= 1000;
            string[] competidoresConJugador = new string[competidores.Length + 1];
            competidores.CopyTo(competidoresConJugador, 0);
            competidoresConJugador[competidores.Length] = $"#{random.Next(0, 100):D2} - {nombreJugador}";
            simularCarrera(competidoresConJugador, true, ref balance, nombreJugador);
        }
        else if (opcionPista == 2)
        {
            if (balance < 100) // Asumimos que la apuesta mínima es 100
            {
                print("No tienes suficiente balance para apostar. Necesitas al menos $100.", 'r');
                Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
                Console.ReadKey();
                return;  // Regresa al menú sin permitir apostar.
            }

            string competidorApostado;
            int posicionApuesta;
            double montoApuesta;

            apostar(ref balance, competidores, out competidorApostado, out posicionApuesta, out montoApuesta);
            simularCarrera(competidores, false, ref balance, nombreJugador, competidorApostado, posicionApuesta, montoApuesta);
        }
    }

    static void apostar(ref double balance, string[] competidores, out string competidorApostado, out int posicionApuesta, out double montoApuesta)
    {
        Console.WriteLine("Elige un competidor para apostar ingresando el número del competidor:");
        for (int i = 0; i < competidores.Length; i++)
        {
            Console.WriteLine($"{competidores[i]}");
        }

        string numeroCompetidor = Console.ReadLine();
        competidorApostado = Array.Find(competidores, c => c.StartsWith($"#{numeroCompetidor}"));

        if (competidorApostado == null)
        {
            print("Competidor no válido. Volviendo al menú...", 'r');
            posicionApuesta = 0;
            montoApuesta = 0;
            return;
        }

        Console.Write($"¿En qué posición llegará {competidorApostado}? (1 - {competidores.Length}): ");
        posicionApuesta = int.Parse(Console.ReadLine());

        Console.WriteLine($"\n¿Cuánto quieres apostar?");
        Console.WriteLine($"Balance: ${balance:F2}");
        montoApuesta = double.Parse(Console.ReadLine());

        if (montoApuesta > balance)
        {
            print("No tienes suficiente balance para realizar esta apuesta.", 'r');
            competidorApostado = null;
            posicionApuesta = 0;
            montoApuesta = 0;
            return;
        }

        balance -= montoApuesta;
    }

    static void simularCarrera(string[] competidores, bool jugadorCompite, ref double balance, string nombreJugador, string competidorApostado = null, int posicionApuesta = 0, double montoApuesta = 0)
    {
        int[] posiciones = new int[competidores.Length];
        for (int i = 0; i < posiciones.Length; i++)
        {
            posiciones[i] = 0;  // Inicializar todas las posiciones de los competidores en 0.
        }

        int distanciaTotal = 50; // Longitud de la carrera.
        bool carreraTerminada = false;

        while (!carreraTerminada)
        {
            Console.Clear();
            Console.WriteLine("Simulando carrera...\n");

            for (int i = 0; i < competidores.Length; i++)
            {
                posiciones[i] += random.Next(1, 4); // Avanzar entre 1 y 3 posiciones.
                posiciones[i] = Math.Min(posiciones[i], distanciaTotal); // Limitar su progreso a la distancia total.

                // Mostrar barra de progreso de cada competidor.
                Console.WriteLine($"{competidores[i]}");
                Console.WriteLine(new string('>', posiciones[i]) + new string(' ', distanciaTotal - posiciones[i]) + "|");
            }

            carreraTerminada = Array.Exists(posiciones, p => p >= distanciaTotal);

            if (!carreraTerminada)
            {
                Console.WriteLine("\nPresiona <Enter> para continuar...");
                Console.ReadLine();
            }
        }

        // Resultados finales
        Console.Clear();
        Console.WriteLine("¡La carrera ha terminado!\n");

        // Crear un arreglo de índices para representar la posición final
        int[] indices = new int[competidores.Length];
        for (int i = 0; i < indices.Length; i++)
        {
            indices[i] = i;
        }

        // Ordenar los competidores según sus posiciones
        Array.Sort(posiciones, indices);

        for (int i = 0; i < competidores.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {competidores[indices[i]]} terminó en la posición {i + 1}");
        }

        if (jugadorCompite)
        {
            int posicionJugador = Array.IndexOf(indices, competidores.Length - 1) + 1;
            double recompensa = (competidores.Length * 1000) / (posicionJugador * 2);
            balance += recompensa;
            Console.WriteLine($"\nTerminaste en la posición {posicionJugador}. Has ganado {recompensa:C}.");
        }
        else if (competidorApostado != null)
        {
            int posicionGanadora = Array.IndexOf(indices, Array.IndexOf(competidores, competidorApostado)) + 1;
            if (posicionGanadora == posicionApuesta)
            {
                double ganancia = montoApuesta * 3; // Triplica la apuesta si acierta la posición.
                balance += ganancia;
                Console.WriteLine($"\n¡Has acertado! {competidorApostado} llegó en la posición {posicionApuesta}. Has ganado {ganancia:C}.");
            }
            else
            {
                Console.WriteLine($"\n{competidorApostado} no llegó en la posición esperada. Has perdido la apuesta.");
            }
        }

        Console.WriteLine($"\nBalance final: {balance:C}");
        Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
        Console.ReadKey();
    }

    static int menu(string[] opciones)
    {
        for (int i = 0; i < opciones.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {opciones[i]}");
        }
        Console.Write("Seleccione una opción: ");
        int opcion = int.Parse(Console.ReadLine());

        while (opcion < 1 || opcion > opciones.Length)
        {
            print("Opción inválida. Intente de nuevo.", 'r');
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());
        }

        return opcion;
    }

    static void print(string msg, char color)
    {
        switch (color)
        {
            case 'r': Console.ForegroundColor = ConsoleColor.Red; break;
            case 'g': Console.ForegroundColor = ConsoleColor.Green; break;
            case 'b': Console.ForegroundColor = ConsoleColor.Blue; break;
            case 'y': Console.ForegroundColor = ConsoleColor.Yellow; break;
        }
        Console.WriteLine(msg);
        Console.ResetColor();
    }

    static void titulo()
    {
        Console.Clear();
        Console.WriteLine("========================");
        Console.WriteLine("  SIMULADOR DE CARRERAS");
        Console.WriteLine("========================");
    }
}
