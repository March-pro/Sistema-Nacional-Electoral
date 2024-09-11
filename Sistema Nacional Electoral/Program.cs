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
    //Usamos la idea de nuestros compañeros Emiliano Martínez y de Luis Martínez de ponerle color al título.
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
    Console.WriteLine("\nBienvenido al Sistema de Votación.");
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
    Console.WriteLine("Ingresa tu elección: \n");
    Console.WriteLine("5. Mostrar resultados");
    Console.WriteLine("6. Simulación de votaciones");
    Console.SetCursorPosition(21, 23);
    opcionVoto = Console.ReadLine();
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

        Console.WriteLine($"Messi ({candidatoA})  {Math.Round(porcentajeMessi, 2)}%   {new string('#', (int)(porcentajeMessi / 2))} ");
        Console.WriteLine($"Mfrappé ({candidatoB})  {Math.Round(porcentajeMfrappé, 2)}%   {new string('#', (int)(porcentajeMfrappé / 2))} ");
        Console.WriteLine($"Penaldo ({candidatoC})  {Math.Round(porcentajePenaldo, 2)}%   {new string('#', (int)(porcentajePenaldo / 2))}");
        Console.WriteLine($"Votos en blanco ({votosNulos})  {Math.Round(porcentajeBlanco, 2)}%   {new string('#', (int)(porcentajeBlanco / 2))}");

        Console.WriteLine("Quisiera seguir ingresando votos? si / no");
        string ans = Console.ReadLine();

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

        Console.WriteLine($"Messi ({candidatoA})  {Math.Round(porcentajeMessi2, 2)}%   {new string('#', (int)(porcentajeMessi2 / 2))} ");
        Console.WriteLine($"Mfrappé ({candidatoB})  {Math.Round(porcentajeMfrappé2, 2)}%   {new string('#', (int)(porcentajeMfrappé2 / 2))} ");
        Console.WriteLine($"Penaldo ({candidatoC})  {Math.Round(porcentajePenaldo2, 2)}%   {new string('#', (int)(porcentajePenaldo2 / 2))}");
        Console.WriteLine($"Votos en blanco ({votosNulos})  {Math.Round(porcentajeBlanco2, 2)}%   {new string('#', (int)(porcentajeBlanco2 / 2))}");

        Console.WriteLine("Quisiera seguir ingresando votos? si / no");
            string answer = Console.ReadLine();
            
            Console.Clear();

        while (answer == "si")
        {
            Console.WriteLine("Perfecto continuemos");
            break;
        }

        if (answer == "no")
        {
            Console.Clear();
            int Votosmaximos = Math.Max(candidatoA, Math.Max(candidatoB, Math.Max(candidatoC, votosNulos)));
            bool empate = false;
            Console.Clear();

            bool empatetotal = (candidatoA == Votosmaximos && candidatoB == Votosmaximos && candidatoC == Votosmaximos && votosNulos == Votosmaximos);
            bool ganamessi = (candidatoA == Votosmaximos);
            bool ganamfrappé = (candidatoB == Votosmaximos);
            bool ganapenaldo = (candidatoC == Votosmaximos);
            bool empateMeyM = (candidatoA == Votosmaximos && candidatoB == Votosmaximos && candidatoA != candidatoC && candidatoA != votosNulos);
            bool empateMyP = (candidatoB == Votosmaximos && candidatoC == Votosmaximos && candidatoA != candidatoC && candidatoC != votosNulos);
            bool empateMeyP = (candidatoC == Votosmaximos && candidatoA == Votosmaximos && candidatoB != candidatoC && candidatoB != votosNulos);

            Console.Clear();

            if (empatetotal!)
            {
                Console.WriteLine("Hubo un empate total entre todos los candidatos y votos en blanco");
            }
            else
            {
                if (ganamessi!)
                {
                    Console.WriteLine("Felicidades, el ganador es Messi!");
                }
                if (ganamfrappé!)
                {
                    Console.WriteLine("Felicidades, el ganador es Mfrappé!");
                }
                if (ganapenaldo!)
                {
                    Console.WriteLine("Felicidades, el ganador es Penaldo!");
                }
                if (empateMeyM!)
                {
                    Console.WriteLine("Rayos, hubo un empate entre Messi y Mfrappé!");
                }
                if (empateMyP!)
                {
                    Console.WriteLine("Rayos, hubo un empate entre Mfrappé y Penaldo!");
                }
                if (empateMeyP!)
                {
                    Console.WriteLine("Rayos, hubo un empate entre Messi y Penaldo!");
                }
            }

            break;

        }
    }


    if (opcionVoto == "6")
    {
        Console.WriteLine("Simulando elecciones, espere un segundo.");

        Random rnd = new Random(); 

        while (totalVotos < 130)
        {
            int simulacionvotos = rnd.Next(1, 5); 

            if (simulacionvotos == 1)
                candidatoA++;
            else if (simulacionvotos == 2)
                candidatoB++;
            else if (simulacionvotos == 3)
                candidatoC++;
            else if (simulacionvotos == 4)
                votosNulos++;

            totalVotos++;
        }

        Console.Clear();

        double porcentajemessisim = 0;
        double porcentajemfrappésim = 0;
        double porcentajepenaldosim = 0;
        double porcentajeblancosim = 0;

        if (totalVotos > 0)
        {
            porcentajemessisim = ((double)candidatoA / totalVotos) * 100;
            porcentajemfrappésim = ((double)candidatoB / totalVotos) * 100;
            porcentajepenaldosim = ((double)candidatoC / totalVotos) * 100;
            porcentajeblancosim = ((double)votosNulos / totalVotos) * 100;
        }

        Console.WriteLine($"Messi ({candidatoA})  {Math.Round(porcentajemessisim, 2)}%  {new string('#', (int)(Math.Round(porcentajemessisim / 2)))}");
        Console.WriteLine($"Mfrappé ({candidatoB})  {Math.Round(porcentajemfrappésim, 2)}%  {new string('#', (int)(Math.Round(porcentajemfrappésim / 2)))}");
        Console.WriteLine($"Penaldo ({candidatoC})  {Math.Round(porcentajepenaldosim, 2)}%  {new string('#', (int)(Math.Round(porcentajepenaldosim / 2)))}");
        Console.WriteLine($"Voto en blanco ({votosNulos})  {Math.Round(porcentajeblancosim, 2)}%  {new string('#', (int)(Math.Round(porcentajeblancosim / 2)))}");


        int votostotalessim = Math.Max(candidatoA, Math.Max(candidatoB, Math.Max(candidatoC, votosNulos)));
        bool empatesim = false;
        bool empatetotalsim = (candidatoA == candidatoB && candidatoA == candidatoC && candidatoA == votosNulos);
        bool ganamessisim = (candidatoA == votostotalessim);
        bool ganamfrappésim = (candidatoB == votostotalessim);
        bool ganapenaldosim = (candidatoC == votostotalessim);
        bool empateMeyMsim = (candidatoA == votostotalessim && candidatoB == votostotalessim && candidatoA != candidatoC && candidatoA != votosNulos);
        bool empateMyPsim = (candidatoB == votostotalessim && candidatoC == votostotalessim && candidatoB != candidatoA && candidatoB != votosNulos);
        bool empateMeyPsim = (candidatoA == votostotalessim && candidatoC == votostotalessim && candidatoA != candidatoB && candidatoA != votosNulos);


        if (empatetotalsim)
        {
            Console.WriteLine("Hubo un empate total entre todos los candidatos y los votos en blanco.");
        }
        else
        {
            if (ganamessisim)
            {
                Console.WriteLine($"Felicidades! Messi es el ganador con {candidatoA} votos.");
            }
            if (ganamfrappésim)
            {
                Console.WriteLine($"Felicdades! Mfrappé es el ganador con {candidatoB} votos.");
            }
            if (ganapenaldosim)
            {
                Console.WriteLine($"Felicidades! Penaldo es el ganador con {candidatoC} votos.");
            }
            if (votosNulos == votostotalessim)
            {
                Console.WriteLine($"Voto en blanco es el más votado con {votosNulos} votos.");
            }
            if (empateMeyMsim)
            {
                Console.WriteLine("Rayos, hubo un empate entre Messi y Mfrappé!");
            }
            if (empateMeyPsim)
            {
                Console.WriteLine("Rayos, hubo un empate entre Messi y Penaldo.");
            }
            if (empateMyPsim)
            {
                Console.WriteLine("Rayos, hubo un empate entre Mfrappé y Penaldo.");
            }
        }

        Console.WriteLine("Presiona cualquier tecla para finalizar...");
        Console.ReadKey();

        break;
    }
   
}
