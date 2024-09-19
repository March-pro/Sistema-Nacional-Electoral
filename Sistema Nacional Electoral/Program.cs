int anchoVentana = Console.WindowWidth; // Obtiene el ancho actual de la ventana de la consola.
int altoVentana = Console.WindowHeight; // Obtiene la altura actual de la ventana de la consola.
string separador = new string('-', anchoVentana); // Crea una cadena separadora de guiones con el ancho de la ventana.
string opcionVoto = ""; // Inicializa la variable que almacenará la opción de voto seleccionada por el usuario.
int totalVotos = 0; // Inicializa el contador de votos totales.
int candidatoA = 0; // Inicializa el contador de votos para el candidato A (Messi).
int candidatoB = 0; // Inicializa el contador de votos para el candidato B (Mfrappé).
int candidatoC = 0; // Inicializa el contador de votos para el candidato C (Penaldo).
int votosNulos = 0; // Inicializa el contador de votos en blanco.
Random generador = new Random(); // Crea una instancia de la clase Random para generar números aleatorios (usado más adelante).
bool seguirVotando = true; // Inicializa un valor booleano para controlar si el ciclo de votación continúa o se detiene.

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
    // Muestra el número total de votos centrado en la pantalla.
    string resumenVotos = $"Votos totales: {totalVotos}";
    Console.WriteLine(resumenVotos.PadLeft((anchoVentana + resumenVotos.Length) / 2));

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"\n" + separador);
    Console.ResetColor();
    // Muestra el menú de opciones de votación.
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
    // Compara la opción ingresada por el usuario y ajusta los contadores de votos según la elección.
    if (opcionVoto == "1")
    {
        candidatoA++;
        totalVotos++; // Incrementa el total de votos.
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
        // Calcula los porcentajes de votos para cada candidato.
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
        // Encuentra las longitudes máximas de los números y porcentajes para formatear la salida de forma uniforme.
        int maxPorcentajeLength = Math.Max(
            Math.Max(porcentajeMessi2.ToString().Length, porcentajeMfrappé2.ToString().Length),
            Math.Max(porcentajePenaldo2.ToString().Length, porcentajeBlanco2.ToString().Length)
            );

        // Muestra los resultados simulados de las votaciones para cada candidato.
        // Se usa PadRight para alinear el nombre "Messi" a la derecha con 20 caracteres, seguido del número de votos.
        // Se utiliza Math.Round para redondear el porcentaje de votos de Messi a 2 decimales y PadLeft para formatear.
        // Finalmente, se genera una barra de progreso con '#' proporcional al porcentaje de votos.
        Console.WriteLine($"Messi".PadRight(20) + $"({candidatoA.ToString().PadLeft(maxLength)})" + $"  {Math.Round(porcentajeMessi2, 2)}%".PadLeft(maxPorcentajeLength + 5) + $"  {new string('#', (int)(Math.Round(porcentajeMessi2 / 2)))}");
        Console.WriteLine($"Mfrappé".PadRight(20) + $"({candidatoB.ToString().PadLeft(maxLength)})" + $"  {Math.Round(porcentajeMfrappé2, 2)}%".PadLeft(maxPorcentajeLength + 5) + $"  {new string('#', (int)(Math.Round(porcentajeMfrappé2 / 2)))}");
        Console.WriteLine($"Penaldo".PadRight(20) + $"({candidatoC.ToString().PadLeft(maxLength)})" + $"  {Math.Round(porcentajePenaldo2, 2)}%".PadLeft(maxPorcentajeLength + 5) + $"  {new string('#', (int)(Math.Round(porcentajePenaldo2 / 2)))}");
        Console.WriteLine($"Voto en blanco".PadRight(20) + $"({votosNulos.ToString().PadLeft(maxLength)})" + $"  {Math.Round(porcentajeBlanco2, 2)}%".PadLeft(maxPorcentajeLength + 5) + $"  {new string('#', (int)(Math.Round(porcentajeBlanco2 / 2)))}");

        Console.WriteLine("Quisiera seguir ingresando votos? si / no");
        string answer = Console.ReadLine();

        Console.Clear();
        // bucle que se repetirá mientras el usuario elija si
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
            //verifica los resultados, ganador y empates
            bool empatetotal = (candidatoA == Votosmaximos && candidatoB == Votosmaximos && candidatoC == Votosmaximos && votosNulos == Votosmaximos);

            bool ganamessi = (candidatoA == Votosmaximos && !(candidatoB == Votosmaximos || candidatoC == Votosmaximos || votosNulos == Votosmaximos));
            bool ganamfrappé = (candidatoB == Votosmaximos && !(candidatoA == Votosmaximos || candidatoC == Votosmaximos || votosNulos == Votosmaximos));
            bool ganapenaldo = (candidatoC == Votosmaximos && !(candidatoA == Votosmaximos || candidatoB == Votosmaximos || votosNulos == Votosmaximos));

            bool empateMeyM = (candidatoA == Votosmaximos && candidatoB == Votosmaximos && candidatoC != Votosmaximos && votosNulos != Votosmaximos);
            bool empateMyP = (candidatoB == Votosmaximos && candidatoC == Votosmaximos && candidatoA != Votosmaximos && votosNulos != Votosmaximos);
            bool empateMeyP = (candidatoC == Votosmaximos && candidatoA == Votosmaximos && candidatoB != Votosmaximos && votosNulos != Votosmaximos); Console.Clear();

            //asigna el valor de resultado votacion
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
            // se mostrará el resultado de la variable resultadovotacion
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

    // Da la simulación de las elecciones
    if (opcionVoto == "6")
    {
        Console.WriteLine("Simulando elecciones, espere un segundo.");
        // Instancia de la clase Random para generar votos aleatorios.
        Random rnd = new Random();
        // Bucle que continúa mientras el total de votos sea menor o igual a 130.
        while (totalVotos <= 130)
        {
            int simulacionvotos = rnd.Next(1, 5);
            // Se genera un número aleatorio entre 1 y 4 para determinar el candidato al que va el voto.
          
            if (simulacionvotos == 1)
                candidatoA++;
            else if (simulacionvotos == 2)
                candidatoB++;
            else if (simulacionvotos == 3)
                candidatoC++;
            else if (simulacionvotos == 4)
                votosNulos++;

            totalVotos++;
            // Condiciones para aumentar el contador del candidato correspondiente o los votos nulos.
        }

        Console.Clear();

        double porcentajemessisim = 0;
        double porcentajemfrappésim = 0;
        double porcentajepenaldosim = 0;
        double porcentajeblancosim = 0;
        // Variables para almacenar los porcentajes de votos de cada opción.

        if (totalVotos > 0)
        // Cálculo de los porcentajes solo si se ha registrado al menos un voto.
        {
            porcentajemessisim = ((double)candidatoA / totalVotos) * 100;
            porcentajemfrappésim = ((double)candidatoB / totalVotos) * 100;
            porcentajepenaldosim = ((double)candidatoC / totalVotos) * 100;
            porcentajeblancosim = ((double)votosNulos / totalVotos) * 100;
        }
        // Cálculo de la longitud máxima de los números de votos para ajustar la alineación.
        int maxLengthSim = Math.Max(
            Math.Max(candidatoA.ToString().Length, candidatoB.ToString().Length),
            Math.Max(candidatoC.ToString().Length, votosNulos.ToString().Length)
        );

        int maxPorcentajeLengthSim = Math.Max(
            Math.Max(porcentajemessisim.ToString().Length, porcentajemfrappésim.ToString().Length),
            Math.Max(porcentajepenaldosim.ToString().Length, porcentajeblancosim.ToString().Length)
            );
        // Muestra los resultados en la consola con gráficos de barras basados en los porcentajes.
        Console.WriteLine($"Messi".PadRight(20) + $"({candidatoA.ToString().PadLeft(maxLengthSim)})" + $"  {Math.Round(porcentajemessisim, 2)}%".PadLeft(maxPorcentajeLengthSim + 5) + $"  {new string('#', (int)(Math.Round(porcentajemessisim / 2)))}");
        Console.WriteLine($"Mfrappé".PadRight(20) + $"({candidatoB.ToString().PadLeft(maxLengthSim)})" + $"  {Math.Round(porcentajemfrappésim, 2)}%".PadLeft(maxPorcentajeLengthSim + 5) + $"  {new string('#', (int)(Math.Round(porcentajemfrappésim / 2)))}");
        Console.WriteLine($"Penaldo".PadRight(20) + $"({candidatoC.ToString().PadLeft(maxLengthSim)})" + $"  {Math.Round(porcentajepenaldosim, 2)}%".PadLeft(maxPorcentajeLengthSim + 5) + $"  {new string('#', (int)(Math.Round(porcentajepenaldosim / 2)))}");
        Console.WriteLine($"Voto en blanco".PadRight(20) + $"({votosNulos.ToString().PadLeft(maxLengthSim)})" + $"  {Math.Round(porcentajeblancosim, 2)}%".PadLeft(maxPorcentajeLengthSim + 5) + $"  {new string('#', (int)(Math.Round(porcentajeblancosim / 2)))}");

        // Inicialización de variables para detectar empates y determinar el ganador.
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
        // Inicializa la variable para almacenar el resultado de la votación.
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
        // Dependiendo del valor de "resultadoVotacionsim", muestra el mensaje correspondiente.
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
        // Espera que el usuario presione una tecla para finalizar la simulación.
        Console.WriteLine("Presiona cualquier tecla para finalizar...");
        Console.ReadKey();

        break;
    }

}
