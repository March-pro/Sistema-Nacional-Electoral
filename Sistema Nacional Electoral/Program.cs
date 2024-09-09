int anchoVentana = Console.WindowWidth;
int altoVentana = Console.WindowHeight;
string separador = new string('-', anchoVentana);
string opcionVoto = "";
int totalVotos = 0;
int candidatoA = 0, candidatoB = 0, candidatoC = 0, votosNulos = 0;
Random generador = new Random();
bool seguirVotando = true;

while (seguirVotando)
{
    Console.WriteLine("  /$$$$$$  /$$            /$$                                             /$$$$$$$$ /$$                      /$$                                  /$$");
    Console.WriteLine(" /$$__  $$|__/           | $$                                            | $$_____/| $$                     | $$                                 | $$");
    Console.WriteLine("| $$  \\__/ /$$  /$$$$$$$/$$$$$$    /$$$$$$  /$$$$$$/$$$$   /$$$$$$       | $$      | $$  /$$$$$$   /$$$$$$$/$$$$$$    /$$$$$$   /$$$$$$  /$$$$$$ | $$");
    Console.WriteLine("|  $$$$$$ | $$ /$$_____/_  $$_/   /$$__  $$| $$_  $$_  $$ |____  $$      | $$$$$   | $$ /$$__  $$ /$$_____/_  $$_/   /$$__  $$ /$$__  $$|____  $$| $$");
    Console.WriteLine(" \\____  $$| $$|  $$$$$$  | $$    | $$$$$$$$| $$ \\ $$ \\ $$  /$$$$$$$      | $$__/   | $$| $$$$$$$$| $$       | $$    | $$  \\ $$| $$  \\__/ /$$$$$$$| $$");
    Console.WriteLine(" /$$  \\ $$| $$ \\____  $$ | $$ /$$| $$_____/| $$ | $$ | $$ /$$__  $$      | $$      | $$| $$_____/| $$       | $$ /$$| $$  | $$| $$      /$$__  $$| $$");
    Console.WriteLine("|  $$$$$$/| $$ /$$$$$$$/ |  $$$$/|  $$$$$$$| $$ | $$ | $$|  $$$$$$$      | $$$$$$$$| $$|  $$$$$$$|  $$$$$$$ |  $$$$/|  $$$$$$/| $$     |  $$$$$$$| $$");
    Console.WriteLine(" \\______/ |__/|_______/   \\___/   \\_______/|__/ |__/ |__/ \\_______/      |________/|__/ \\_______/ \\_______/  \\___/   \\______/ |__/      \\_______/|__/");
    Console.WriteLine("                                                                                                                                                     ");
    Console.WriteLine("                                                                                                                                                     ");
    Console.WriteLine("                                                                                                                                                     ");
    Console.WriteLine("\nBienvenido al Sistema de Votación. Vota con responsabilidad.");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"\n" + separador + "\n");
    Console.ResetColor();

    string resumenVotos = $"Votos totales: {totalVotos}";
    Console.WriteLine(resumenVotos.PadLeft((anchoVentana + resumenVotos.Length) / 2));

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"\n" + separador);
    Console.ResetColor();

    Console.WriteLine("Selecciona a tu candidato favorito ingresando su número correspondiente.\n");
    Console.WriteLine("1. Messi");
    Console.WriteLine("2. Mfrappé");
    Console.WriteLine("3. Penaldo");
    Console.WriteLine("4. Voto en blanco");
    Console.WriteLine("5. Mostrar resultados");
    Console.WriteLine("6. Simulación de votaciones");

    Console.Write("Ingresa tu elección: ");
    opcionVoto = Console.ReadLine();

    switch (opcionVoto)
    {
        case "1":
            candidatoA++;
            totalVotos++;
            break;
        case "2":
            candidatoB++;
            totalVotos++;
            break;
        case "3":
            candidatoC++;
            totalVotos++;
            break;
        case "4":
            votosNulos++;
            totalVotos++;
            break;
        case "5":
            MostrarResultados(candidatoA, candidatoB, candidatoC, votosNulos, totalVotos);
            break;
        case "6":
            SimulacionVotos(generador, ref candidatoA, ref candidatoB, ref candidatoC, ref votosNulos, ref totalVotos);
            break;
        default:
            Console.WriteLine("Opción no válida. Inténtalo nuevamente.");
            Console.ReadKey();
            break;
    }
}

void MostrarResultados(int a, int b, int c, int blanco, int total)
{
    double porcentajeA = (total > 0) ? ((double)a / total) * 100 : 0;
    double porcentajeB = (total > 0) ? ((double)b / total) * 100 : 0;
    double porcentajeC = (total > 0) ? ((double)c / total) * 100 : 0;
    double porcentajeBlanco = (total > 0) ? ((double)blanco / total) * 100 : 0;

    Console.WriteLine($"Candidato A: {a} votos ({porcentajeA:F1}%) {new string('#', (int)(porcentajeA / 2))}");
    Console.WriteLine($"Candidato B: {b} votos ({porcentajeB:F1}%) {new string('#', (int)(porcentajeB / 2))}");
    Console.WriteLine($"Candidato C: {c} votos ({porcentajeC:F1}%) {new string('#', (int)(porcentajeC / 2))}");
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
