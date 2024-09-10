int anchoVentana = Console.WindowWidth;
int altoVentana = Console.WindowHeight;
string separador = new string('-', anchoVentana);
string opcionVoto = "";
int totalVotos = 0;
int candidatoA = 0;
int candidatoB = 0;
int candidatoC = 0;
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

    Console.WriteLine("Selecciona a tu candidato favorito ingresando su número correspondiente.\n");
    Console.WriteLine("1. Messi");
    Console.WriteLine("2. Mfrappé");
    Console.WriteLine("3. Penaldo");
    Console.WriteLine("4. Voto en blanco\n");
    Console.SetCursorPosition(0, 26);
    Console.Write("Ingresa tu elección: ");
    opcionVoto = Console.ReadLine();
    Console.WriteLine("5. Mostrar resultados");
    Console.WriteLine("6. Simulación de votaciones");
    
    Console.Clear();

    if (opcionVoto == "1")
    {
        candidatoA++;
        totalVotos++;
    }
    else if (opcionVoto == "2")
    {
        candidatoB++;
        totalVotos++;
    }
    else if (opcionVoto == "3")
    {
        candidatoC++;
        totalVotos++;
    }
    else if (opcionVoto == "4")
    {
        votosNulos++;
        totalVotos++;
    }
    else if (opcionVoto == "5")
    {
        double porcentajeMessi = 0;
        double porcentajeMfrappé = 0;
        double porcentajePenaldo = 0;
        double porcentajeBlanco = 0;
        if (totalVotos > 0)
        {
            porcentajeMessi = ((double)candidatoA / totalVotos) * 100;
            porcentajeMfrappé = ((double)candidatoB / totalVotos) * 100;
            porcentajePenaldo = ((double)candidatoC / totalVotos) * 100;
            porcentajeBlanco = ((double)votosNulos / totalVotos) * 100;
        };

        Console.WriteLine($"Messi ({candidatoA})  {porcentajeMessi:F1}%   {new string('#', (int)(porcentajeMessi / 2))} ");
        Console.WriteLine($"Mfrappé ({candidatoB})  {porcentajeMfrappé:F1}%   {new string('#', (int)(porcentajeMfrappé / 2))} ");
        Console.WriteLine($"Penaldo ({candidatoC})  {porcentajePenaldo:F1}%   {new string('#', (int)(porcentajePenaldo / 2))}");
        Console.WriteLine($"Votos en blanco ({votosNulos})  {porcentajeBlanco:F1}%   {new string('#', (int)(porcentajeBlanco / 2))}");

        Console.WriteLine("Quisiera seguir ingresando votos? si / no");
        string ans = Console.ReadLine();

        if (ans == "si")
        {
            Console.WriteLine("Perfecto continuemos");
            break;
        }

        if (ans == "no")
        {
            Console.Clear();
            double porcentajeMessi2 = 0;
            double porcentajeMfrappé2 = 0;
            double porcentajePenaldo2 = 0;
            double porcentajeBlanco2 = 0;
            if (totalVotos > 0)
            {
                porcentajeMessi2 = ((double)candidatoA / totalVotos) * 100;
                porcentajeMfrappé2 = ((double)candidatoB / totalVotos) * 100;
                porcentajePenaldo2 = ((double)candidatoC / totalVotos) * 100;
                porcentajeBlanco2 = ((double)votosNulos / totalVotos) * 100;
            };

            Console.WriteLine($"Messi ({candidatoA})  {porcentajeMessi2:F1}%   {new string('#', (int)(porcentajeMessi2 / 2))} ");
            Console.WriteLine($"Mfrappé ({candidatoB})  {porcentajeMfrappé2:F1}%   {new string('#', (int)(porcentajeMfrappé2 / 2))} ");
            Console.WriteLine($"Penaldo ({candidatoC})  {porcentajePenaldo2:F1}%   {new string('#', (int)(porcentajePenaldo2 / 2))}");
            Console.WriteLine($"Votos en blanco ({votosNulos})  {porcentajeBlanco2:F1}%   {new string('#', (int)(porcentajeBlanco2 / 2))}");

            int Votosmaximos = Math.Max(candidatoA, Math.Max(candidatoB, Math.Max(candidatoC, votosNulos)));
            bool empate = false;

            if (candidatoA == Votosmaximos && candidatoB == Votosmaximos && candidatoC == Votosmaximos && votosNulos == Votosmaximos)
            {
                Console.WriteLine("Hubo un empate total entre todos los candidatos y votos en blanco");
            }
            else
            {
                if (candidatoA == Votosmaximos)
                {
                    Console.WriteLine("Felicidades, el ganador es Messi!");
                }
                if (candidatoB == Votosmaximos)
                {
                    Console.WriteLine("Felicidades, el ganador es Mfrappé");
                }
                if (candidatoC == Votosmaximos)
                {
                    Console.WriteLine("Felicidades, el ganador es Penaldo");
                }
                if (candidatoA == Votosmaximos && candidatoB == Votosmaximos && candidatoA != candidatoC && candidatoA != votosNulos)
                {
                    Console.WriteLine("Rayos, hubo un empate entre Messi y Mfrappé!");
                }
            }
        }
    }
    else if (opcionVoto == "6")
    { 
    
    }
    else
    {
        Console.WriteLine("Opción no válida. Inténtalo nuevamente.");
        Console.ReadKey();
    }
}
