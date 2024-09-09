int anchoVentana = Console.WindowWidth;
int altoVentana = Console.WindowHeight;
string separador = new string('-', anchoVentana);
string opcionVoto = "";
int totalVotos = 0;
int Messi = 0;
int Mfrappé = 0;
int Penaldo = 0;
int votosNulos = 0;
Random generador = new Random();
bool seguirVotando = true;

while (seguirVotando)
{
    //Aquí usamos chat GPT para ver como ponerle colores a cada ciertas lineas del titulo
    //Usamos la idea de nuestros compañeros Emiliano Martínez y de Luis Martínez de poerle color al título.
    //Funciona con el comando Console.ForegroundColor = ConsoleColor.(color asignado);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("  /$$$$$$  /$$            /$$                                             /$$$$$$$$ /$$                      /$$                                  /$$");

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(" /$$__  $$|__/           | $$                                            | $$_____/| $$                     | $$                                 | $$");
    Console.WriteLine("| $$  \\__/ /$$  /$$$$$$$/$$$$$$    /$$$$$$  /$$$$$$/$$$$   /$$$$$$       | $$      | $$  /$$$$$$   /$$$$$$$/$$$$$$    /$$$$$$   /$$$$$$  /$$$$$$ | $$");

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("|  $$$$$$ | $$ /$$_____/_  $$_/   /$$__  $$| $$_  $$_  $$ |____  $$      | $$$$$   | $$ /$$__  $$ /$$_____/_  $$_/   /$$__  $$ /$$__  $$|____  $$| $$");
    Console.WriteLine(" \\____  $$| $$|  $$$$$$  | $$    | $$$$$$$$| $$ \\ $$ \\ $$  /$$$$$$$      | $$__/   | $$| $$$$$$$$| $$       | $$    | $$  \\ $$| $$  \\__/ /$$$$$$$| $$");

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(" /$$  \\ $$| $$ \\____  $$ | $$ /$$| $$_____/| $$ | $$ | $$ /$$__  $$      | $$      | $$| $$_____/| $$       | $$ /$$| $$  | $$| $$      /$$__  $$| $$");

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("|  $$$$$$/| $$ /$$$$$$$/ |  $$$$/|  $$$$$$$| $$ | $$ | $$|  $$$$$$$      | $$$$$$$$| $$|  $$$$$$$|  $$$$$$$ |  $$$$/|  $$$$$$/| $$     |  $$$$$$$| $$");

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(" \\______/ |__/|_______/   \\___/   \\_______/|__/ |__/ |__/ \\_______/      |________/|__/ \\_______/ \\_______/  \\___/   \\______/ |__/      \\_______/|__/");

    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("\nBienvenido al Sistema de Votación. Vota con responsabilidad.");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"\n" + separador + "\n");
    Console.ResetColor();

    string resumenVotos = $"Votos totales: {totalVotos}";
    Console.WriteLine(resumenVotos.PadLeft((anchoVentana + resumenVotos.Length) / 2));

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"\n" + separador);
    Console.ResetColor();

    // Menú de opciones
    Console.WriteLine("Selecciona a tu candidato favorito ingresando su número correspondiente.\n");
    Console.WriteLine("1. Messi");
    Console.WriteLine("2. Mfrappé");
    Console.WriteLine("3. Penaldo");
    Console.WriteLine("4. Voto en blanco\n");

    Console.WriteLine("5. Mostrar resultados");
    Console.WriteLine("6. Simulación de votaciones");
    Console.SetCursorPosition(0, 26);
    Console.Write("Ingresa tu elección: ");
    opcionVoto = Console.ReadLine();

    if (opcionVoto == "1")
    {
        Messi++;
        totalVotos++;
    }
    else if (opcionVoto == "2")
    {
        Mfrappé++;
        totalVotos++;
    }
    else if (opcionVoto == "3")
    {
        Penaldo++;
        totalVotos++;
    }
    else if (opcionVoto == "4")
    {
        votosNulos++;
        totalVotos++;
    }
    else if (opcionVoto == "5")
    {
        MostrarResultados(Messi, Mfrappé, Penaldo, votosNulos, totalVotos);
    }
    else if (opcionVoto == "6")
    {
        SimulacionVotos(generador, ref Messi, ref Mfrappé, ref Penaldo, ref votosNulos, ref totalVotos);
    }
    else
    {
        Console.WriteLine("Opción no válida. Inténtalo nuevamente.");
        Console.ReadKey();
    }
}

void MostrarResultados(int a, int b, int c, int blanco, int total)
{
    double porcentajeA = (total > 0) ? ((double)a / total) * 100 : 0;
    double porcentajeB = (total > 0) ? ((double)b / total) * 100 : 0;
    double porcentajeC = (total > 0) ? ((double)c / total) * 100 : 0;
    double porcentajeBlanco = (total > 0) ? ((double)blanco / total) * 100 : 0;

    Console.WriteLine($"Messi: {a} votos ({porcentajeA:F1}%) {new string('#', (int)(porcentajeA / 2))}");
    Console.WriteLine($"Mfrappé: {b} votos ({porcentajeB:F1}%) {new string('#', (int)(porcentajeB / 2))}");
    Console.WriteLine($"Penaldo: {c} votos ({porcentajeC:F1}%) {new string('#', (int)(porcentajeC / 2))}");
    Console.WriteLine($"Voto en blanco: {blanco} votos ({porcentajeBlanco:F1}%) {new string('#', (int)(porcentajeBlanco / 2))}");
}

void SimulacionVotos(Random rng, ref int a, ref int b, ref int c, ref int blanco, ref int total)
{
    while (total < 3000)
    {
        int votoAleatorio = rng.Next(1, 5);
        if (votoAleatorio == 1) a++;
        else if (votoAleatorio == 2) b++;
        else if (votoAleatorio == 3) c++;
        else blanco++;
        total++;
    }

    Console.Clear();
    MostrarResultados(a, b, c, blanco, total);
    Console.WriteLine("Simulación completada.");
    Console.ReadKey();
}
