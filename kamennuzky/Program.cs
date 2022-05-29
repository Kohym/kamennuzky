Random random = new Random();
int hracwin = 0;
int botwin = 0;
string bot = "";
string hrac = "";

while (hracwin != 5 & botwin != 5)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"más {hracwin} bodů");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"protihráč má {botwin} bodů");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Zadej: kámen, papír nebo nůžky");
    hrac = Console.ReadLine();
    if (hrac != "kámen" & hrac != "papír" & hrac != "nůžky")
    {
        Console.WriteLine(value: "neumíš psát debile");
        Console.ReadKey();
    }
    else
    {
        switch (random.Next(1, 4))
        {
            case 1:
                bot = "kámen";
                break;
            case 2:
                bot = "nůžky";
                break;
            case 3:
                bot = "papír";
                break;
        }
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"zadal jsi: {hrac}");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"protihráč zadal: {bot}");
        Console.ForegroundColor = ConsoleColor.White;
        switch (hrac)
        {
            case "kámen":
                if (bot == "kámen")
                {
                    Console.WriteLine("remíza");
                }
                else if (bot == "papír")
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("prohrál jsi");
                    Console.BackgroundColor = ConsoleColor.Black;
                    botwin++;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Vyhral jsi");
                    Console.BackgroundColor = ConsoleColor.Black;
                    hracwin++;
                }
                break;
            case "papír":
                if (bot == "kámen")
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Vyhral jsi");
                    Console.BackgroundColor = ConsoleColor.Black;
                    hracwin++;
                }
                else if (bot == "papír")
                {
                    Console.WriteLine("remíza");
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("prohrál jsi");
                    Console.BackgroundColor = ConsoleColor.Black;
                    botwin++;
                }
                break;
            case "nůžky":
                if (bot == "kámen")
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("prohrál jsi");
                    Console.BackgroundColor = ConsoleColor.Black;
                    botwin++;
                }
                else if (bot == "papír")
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Vyhral jsi");
                    Console.BackgroundColor = ConsoleColor.Black;
                    hracwin++;
                }
                else
                {
                    Console.WriteLine("remíza");
                }
                break;
        }
        Console.ReadKey();
    }
}
Console.Clear();
if (botwin == 5)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"nedal jsi to ale měl jsi {hracwin} body :(");
    Console.ForegroundColor = ConsoleColor.White;
}
else if (hracwin == 5)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"GG vyhrál jsi a soupeř měl jenom {botwin} body! :)");
    Console.ForegroundColor = ConsoleColor.White;
}