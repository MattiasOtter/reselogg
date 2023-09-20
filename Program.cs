/* class Journeys
{
    public string travels;
    public int km;

    public void distance()
    {

    }
} */

internal class Program
{
    static List<string> travelList = new();

    private static void Main(string[] args)
    {
        // Journeys journey1 = new Journeys();
        //                    UPPGIFT RESELOGG! ! ! ! ! ! ! !

        while (true)
        {
            ShowMenu();

            char key = Console.ReadKey().KeyChar;
            if (char.IsDigit(key))
            {
                int choice = int.Parse(key.ToString());

                switch (choice)
                {
                    case 1:
                        AddTravels();
                        break;

                    case 2:
                        ClearLog();
                        break;

                    case 3:
                        ShowLog();

                        break;

                    case 4:
                        Console.Clear();

                        Console.WriteLine("Vilken resa vill du lägga till distans på?");
                        for (int i = 0; i < travelList.Count; i++)
                        {
                            Console.WriteLine(i + 1 + ": " + travelList[i]);

                        }
                        string indexToChange = Console.ReadLine();
                        Console.WriteLine(indexToChange);




                        // // TODO: Lägg till distanser
                        // Console.Write("Skriv in något: ");
                        // int test = TryGetInt(Console.ReadLine());
                        // Console.WriteLine(test);
                        // Console.Clear();
                        // Console.WriteLine("Vilken resa vill du lägga till distans på?");
                        // for (int i = 0; i < travelList.Count; i++)
                        // {
                        //     Console.ForegroundColor = ConsoleColor.Blue;
                        //     Console.WriteLine(i + 1 + ": " + travelList[i]);
                        // }
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Ogiltigt kommando, försök igen!");
                        break;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Tryck valfri knapp för att fortsätta!");
            Console.ReadKey();
            Console.Clear();
        }

        static void ShowMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" _-_-_-_-_-_-_-_-_-_-_-_-_-_-_");
            Console.WriteLine("|                             |");
            Console.WriteLine("| VÄLKOMMEN TILL DIN RESELOGG |");
            Console.WriteLine("|                             |");
            Console.WriteLine(" -----------------------------");
            Console.WriteLine("| [1] Lägg till resmål.       |");
            Console.WriteLine("| [2] Rensa reseloggen.       |");
            Console.WriteLine("| [3] Visa resmål.            |");
            Console.WriteLine("| [4] Lägg till distans.      |");
            Console.WriteLine("| [0] Avsluta.                |");
            Console.WriteLine(" -----------------------------");
            Console.ResetColor();
        }

        static void AddTravels()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Skriv ner det resmål du vill lägga till!");
            Console.ForegroundColor = ConsoleColor.Blue;
            string travel = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(travel))
            {
                travelList.Add(travel);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ogiltig inmatning. Skriv in vad ditt resmål heter.");
            }
        }

        static void ClearLog()
        {
            Console.Clear();
            travelList.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Reseloggen är nu rensad!");
        }
        static void ShowLog()
        {
            Console.Clear();
            for (int i = 0; i < travelList.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(i + 1 + ": " + travelList[i]);
            }
        }

        /* static int TryGetInt(string message)
        {
            int result = 0;

            bool success = false;

            while (success == false)
            {
                //TODO 1. Byt ut meddelandet mot en variabel
                Console.WriteLine(message);

                string input = Console.ReadLine();
                if (int.TryParse(input, out result) && result >= 0)
                {
                    success = true;
                }
                //TODO 2. Tillåt inte negativa värden om vi inte vill
                else Console.WriteLine("Nu blev det fel, försök igen!");
            }

            return result;
        } */


    }
}