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

        int maxLength = Math.Max(
         Math.Max(candidatoA.ToString().Length, candidatoB.ToString().Length),
         Math.Max(candidatoC.ToString().Length, votosNulos.ToString().Length)
        );

        int maxPorcentajeLength = Math.Max(
            Math.Max(porcentajeMessi2.ToString().Length, porcentajeMfrappé2.ToString().Length),
            Math.Max(porcentajePenaldo2.ToString().Length, porcentajeBlanco2.ToString().Length)
            );

        Console.WriteLine($"Messi".PadRight(20) + $"({candidatoA.ToString().PadLeft(maxLength)})" + $"  {Math.Round(porcentajeMessi2, 2)}%".PadLeft(maxPorcentajeLength + 5) + $"  {new string('#', (int)(Math.Round(porcentajeMessi2 / 2)))}");
        Console.WriteLine($"Mfrappé".PadRight(20) + $"({candidatoB.ToString().PadLeft(maxLength)})" + $"  {Math.Round(porcentajeMfrappé2, 2)}%".PadLeft(maxPorcentajeLength + 5) + $"  {new string('#', (int)(Math.Round(porcentajeMfrappé2 / 2)))}");
        Console.WriteLine($"Penaldo".PadRight(20) + $"({candidatoC.ToString().PadLeft(maxLength)})" + $"  {Math.Round(porcentajePenaldo2, 2)}%".PadLeft(maxPorcentajeLength + 5) + $"  {new string('#', (int)(Math.Round(porcentajePenaldo2 / 2)))}");
        Console.WriteLine($"Voto en blanco".PadRight(20) + $"({votosNulos.ToString().PadLeft(maxLength)})" + $"  {Math.Round(porcentajeBlanco2, 2)}%".PadLeft(maxPorcentajeLength + 5) + $"  {new string('#', (int)(Math.Round(porcentajeBlanco2 / 2)))}");

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
            string resultadoVotacion = "";
            Console.Clear();

            bool empatetotal = (candidatoA == Votosmaximos && candidatoB == Votosmaximos && candidatoC == Votosmaximos && votosNulos == Votosmaximos);

            bool ganamessi = (candidatoA == Votosmaximos && !(candidatoB == Votosmaximos || candidatoC == Votosmaximos || votosNulos == Votosmaximos));
            bool ganamfrappé = (candidatoB == Votosmaximos && !(candidatoA == Votosmaximos || candidatoC == Votosmaximos || votosNulos == Votosmaximos));
            bool ganapenaldo = (candidatoC == Votosmaximos && !(candidatoA == Votosmaximos || candidatoB == Votosmaximos || votosNulos == Votosmaximos));

            bool empateMeyM = (candidatoA == Votosmaximos && candidatoB == Votosmaximos && candidatoC != Votosmaximos && votosNulos != Votosmaximos);
            bool empateMyP = (candidatoB == Votosmaximos && candidatoC == Votosmaximos && candidatoA != Votosmaximos && votosNulos != Votosmaximos);
            bool empateMeyP = (candidatoC == Votosmaximos && candidatoA == Votosmaximos && candidatoB != Votosmaximos && votosNulos != Votosmaximos); Console.Clear();

            if (empatetotal)
            {
                resultadoVotacion = "empateTotal";
            }
            else if (empateMeyM)
            {
                resultadoVotacion = "empateMeyM";
            }
            else if (empateMyP)
            {
                resultadoVotacion = "empateMyP";
            }
            else if (empateMeyP)
            {
                resultadoVotacion = "empateMeyP";
            }
            else if (ganamessi)
            {
                resultadoVotacion = "ganamessi";
            }
            else if (ganamfrappé)
            {
                resultadoVotacion = "ganamfrappé";
            }
            else if (ganapenaldo)
            {
                resultadoVotacion = "ganapenaldo";
            }

            Console.Clear();

            switch (resultadoVotacion)
            {
                case "empateTotal":
                    Console.WriteLine("Hubo un empate total entre todos los candidatos y votos en blanco");
                    break;

                case "empateMeyM":
                    Console.WriteLine("Mierda, hubo un empate entre Messi y Mfrappé!");
                    break;

                case "empateMyP":
                    Console.WriteLine("Mierda, hubo un empate entre Mfrappé y Penaldo!");
                    break;

                case "empateMeyP":
                    Console.WriteLine("Mierda, hubo un empate entre Messi y Penaldo!");
                    break;

                case "ganamessi":
                    Console.WriteLine("Felicidades, el ganador es Messi!");
                    break;

                case "ganamfrappé":
                    Console.WriteLine("Felicidades, el ganador es Mfrappé!");
                    break;

                case "ganapenaldo":
                    Console.WriteLine("Felicidades, el ganador es Penaldo!");
                    break;

            }
            break;
        }
    }


    if (opcionVoto == "6")
    {
        Console.WriteLine("Simulando elecciones, espere un segundo.");

        Random rnd = new Random();

        while (totalVotos <= 130)
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

        int maxLengthSim = Math.Max(
            Math.Max(candidatoA.ToString().Length, candidatoB.ToString().Length),
            Math.Max(candidatoC.ToString().Length, votosNulos.ToString().Length)
        );

        int maxPorcentajeLengthSim = Math.Max(
            Math.Max(porcentajemessisim.ToString().Length, porcentajemfrappésim.ToString().Length),
            Math.Max(porcentajepenaldosim.ToString().Length, porcentajeblancosim.ToString().Length)
            );

        Console.WriteLine($"Messi".PadRight(20) + $"({candidatoA.ToString().PadLeft(maxLengthSim)})" + $"  {Math.Round(porcentajemessisim, 2)}%".PadLeft(maxPorcentajeLengthSim + 5) + $"  {new string('#', (int)(Math.Round(porcentajemessisim / 2)))}");
        Console.WriteLine($"Mfrappé".PadRight(20) + $"({candidatoB.ToString().PadLeft(maxLengthSim)})" + $"  {Math.Round(porcentajemfrappésim, 2)}%".PadLeft(maxPorcentajeLengthSim + 5) + $"  {new string('#', (int)(Math.Round(porcentajemfrappésim / 2)))}");
        Console.WriteLine($"Penaldo".PadRight(20) + $"({candidatoC.ToString().PadLeft(maxLengthSim)})" + $"  {Math.Round(porcentajepenaldosim, 2)}%".PadLeft(maxPorcentajeLengthSim + 5) + $"  {new string('#', (int)(Math.Round(porcentajepenaldosim / 2)))}");
        Console.WriteLine($"Voto en blanco".PadRight(20) + $"({votosNulos.ToString().PadLeft(maxLengthSim)})" + $"  {Math.Round(porcentajeblancosim, 2)}%".PadLeft(maxPorcentajeLengthSim + 5) + $"  {new string('#', (int)(Math.Round(porcentajeblancosim / 2)))}");


        int votostotalessim = Math.Max(candidatoA, Math.Max(candidatoB, Math.Max(candidatoC, votosNulos)));
        bool empatesim = false;
        string resultadoVotacionsim = "";

        bool empatetotalsim = (candidatoA == votostotalessim && candidatoB == votostotalessim && candidatoC == votostotalessim && votosNulos == votostotalessim);
        bool ganamessisim = (candidatoA == votostotalessim && !(candidatoB == votostotalessim || candidatoC == votostotalessim || votosNulos == votostotalessim));
        bool ganamfrappésim = (candidatoB == votostotalessim && !(candidatoA == votostotalessim || candidatoC == votostotalessim || votosNulos == votostotalessim));
        bool ganapenaldosim = (candidatoC == votostotalessim && !(candidatoA == votostotalessim || candidatoB == votostotalessim || votosNulos == votostotalessim));

        bool empateMeyMsim = (candidatoA == votostotalessim && candidatoB == votostotalessim && candidatoC != votostotalessim && votosNulos != votostotalessim);
        bool empateMyPsim = (candidatoB == votostotalessim && candidatoC == votostotalessim && candidatoA != votostotalessim && votosNulos != votostotalessim);
        bool empateMeyPsim = (candidatoA == votostotalessim && candidatoC == votostotalessim && candidatoB != votostotalessim && votosNulos != votostotalessim);

        int resultado;
        if (empatetotalsim)
        {
            resultadoVotacionsim = "empatetotalsim";
        }
        else if (ganamessisim)
        {
            resultadoVotacionsim = "ganamessisim";
        }
        else if (ganamfrappésim)
        {
            resultadoVotacionsim = "ganamfrappésim";
        }
        else if (ganapenaldosim)
        {
            resultadoVotacionsim = "ganapenaldosim";
        }
        else if (votosNulos == votostotalessim)
        {
            resultadoVotacionsim = "votosnulossim";
        }
        else if (empateMeyMsim)
        {
            resultadoVotacionsim = "empateMeyMsim";
        }
        else if (empateMeyPsim)
        {
            resultadoVotacionsim = "empateMeyPlsim";
        }
        else if (empateMyPsim)
        {
            resultadoVotacionsim = "empateMyPsim";
        }

        switch (resultadoVotacionsim)
        {
            case "empatetotalsim":
                Console.WriteLine("Hubo un empate total entre todos los candidatos y los votos en blanco.");
                break;
            case "ganamessisim":
                Console.WriteLine($"Felicidades! Messi es el ganador con {candidatoA} votos.");
                break;
            case "ganamfrappésim":
                Console.WriteLine($"Felicidades! Mfrappé es el ganador con {candidatoB} votos.");
                break;
            case "ganapenaldosim":
                Console.WriteLine($"Felicidades! Penaldo es el ganador con {candidatoC} votos.");
                break;
            case "votosnulossim":
                Console.WriteLine($"Voto en blanco es el más votado con {votosNulos} votos.");
                break;
            case "empateMeyMsim":
                Console.WriteLine("Mierda, hubo un empate entre Messi y Mfrappé!");
                break;
            case "empateMeyP":
                Console.WriteLine("Mierda, hubo un empate entre Messi y Penaldo.");
                break;
            case "empateMyP":
                Console.WriteLine("Mierda, hubo un empate entre Mfrappé y Penaldo.");
                break;
        }

        Console.WriteLine("Presiona cualquier tecla para finalizar...");
        Console.ReadKey();

        break;
    }

}
