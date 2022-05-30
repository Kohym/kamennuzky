using kamennuzky;
#region proměnécreate
Random random = new Random();
int hracwin = 0;
int botwin = 0;
string bot = "";
string hrac = "";
bool lore1 = false;
bool lore2 = false;
bool lore3 = false;
#endregion proměnécreate
#region gamestart
Console.BackgroundColor = ConsoleColor.Red;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("pro optimální expirience hraj v maximalizovaném okně");
Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine("zmáčkni cokoliv pro start hry");
Console.ResetColor();
Console.ReadKey();
Console.Clear();
#endregion gamestart
Console.WriteLine("Chceš ve hře Lore? y/n");
string lore = Console.ReadLine();
#region lore1
if (lore == "y" || lore == "Y")
{
    Console.Clear();
    lore = "y";
    Console.WriteLine("Lore:");
    Console.Write("V roce 1987 se v fredyho kámen restauraci zaměstnanec jménem ");
    Console.ForegroundColor= ConsoleColor.Blue;
    Console.Write("Wiliam Afton ");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("zahrál nůžky na 5 dětí které zahráli papír a jejich mrtvá těla nacpal do animatroniků kteří v restauraci chilovali");
}
else
{
    Console.Clear();
    Console.WriteLine("nechceš lore tak užívej");
}
#endregion lore1
Console.ReadKey();
Console.Clear();

#region game
while (hracwin != 5 & botwin != 5)
{
    #region lore2
    winhrac trida = new winhrac();
    if ((hracwin == 0 || botwin == 0) & lore == "y" & lore1 == false)
    {
        lore1 = true;
        Console.Write("Jsi ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Wiliam Afton ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("který po incident nazvaným: šmik 87 musí bojovat proti policii aby nenašli těla");
        Console.ReadKey();
    }
    else if ((hracwin == 2 || botwin == 2) &  lore == "y" & lore2 == false)
    {
        Console.Clear();
        lore2 = true;
        Console.WriteLine("zatím se ti to daří ale už tě to přestává bavit");
        Console.ReadKey();
    }
    else if ((hracwin == 2 || botwin == 2) & lore == "y" & lore3 == false) 
    {
        Console.Clear();
        lore3 = true;
        Console.WriteLine("Zvládl jsi to až sem ale už tě nebaví se schovávat tak jsi šel do již zavřené budovy kde se stal šmik 87 a chtěl jsi zničit ty animatroniky teré ovládly duš šmiknutých dětí");
        Console.ReadKey();
    }
    #endregion lore2
    Console.Clear();
    Console.ResetColor();
    #region gamestartingtext
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"más {hracwin} bodů");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"protihráč má {botwin} bodů");
    Console.ResetColor();
    Console.WriteLine("Zadej: kámen, papír nebo nůžky");
    #endregion gamestartingtext
    hrac = Console.ReadLine();
    #region umispsat?
    if (hrac != "kámen" & hrac != "papír" & hrac != "nůžky")
    {
        Console.WriteLine(value: "neumíš psát debile");
        Console.ReadKey();
    }
    #endregion umispsat?
    #region acualgame
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
        Console.ResetColor();
        switch (hrac)
        {
            case "kámen":
                if (bot == "kámen")
                {
                    Console.WriteLine("remíza");
                }
                else if (bot == "papír")
                {
                    trida.WinBot();
                    botwin++;
                }
                else
                {
                    trida.WinHrac();
                    hracwin++;
                }
                break;
            case "papír":
                if (bot == "kámen")
                {
                    trida.WinHrac();
                    hracwin++;
                }
                else if (bot == "papír")
                {
                    Console.WriteLine("remíza");
                }
                else
                {
                    trida.WinBot();
                    botwin++;
                }
                break;
            case "nůžky":
                if (bot == "kámen")
                {
                    trida.WinBot();
                    botwin++;
                }
                else if (bot == "papír")
                {
                    trida.WinHrac();
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
    #endregion acualgame
}
#endregion game
Console.Clear();
#region end
if (botwin == 5 & lore == "y" || lore == "Y")
{
    Console.WriteLine("Přišl jsi tvaří v tvář s kámen animatroniky a zahrál jsi na ně svůj nůžky move ale byl jsi kokot protže oni zahráli kámen (jsou kamení) a zabili tě");
    Console.WriteLine("The end");
}
else if (hracwin == 5 & lore == "y" || lore == "Y")
{
    Console.WriteLine("Přišl jsi tvaří v tvář s kámen animatroniky a zahrál jsi na ně papír a tím jsi je porazil");
    Console.WriteLine("The end");
}
else if (botwin == 5 & lore != "y")
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"nedal jsi to ale měl jsi {hracwin} body :(");
    Console.ForegroundColor = ConsoleColor.White;
}
else if (hracwin == 5 & lore != "y")
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"GG vyhrál jsi a soupeř měl jenom {botwin} body! :)");
    Console.ForegroundColor = ConsoleColor.White;
}
#endregion end