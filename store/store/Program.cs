int pengar = 250;

while (pengar > 0)
{
    Console.WriteLine($"Du har så mycket {pengar} pengar kvar");

    Console.WriteLine("Vad vill du köpa?");
    Console.WriteLine("1. En tavla (40kr)");
    Console.WriteLine("2. En bil (55kr)");
    Console.WriteLine("3. Ett hus (60kr)");
    Console.WriteLine("4. Ett barn (95kr)");    

    string köpaVad = "";
    while (köpaVad != "1" && köpaVad != "2" && köpaVad != "3" && köpaVad != "4")
    {
        köpaVad = Console.ReadLine();
    }


    int prisPerVara = 0;

    if (köpaVad == "1")
    {
        prisPerVara = 40;
    }
    else if (köpaVad == "2")
    {
        prisPerVara = 55;
    }
    else if (köpaVad == "3")
    {
        prisPerVara = 60;
    }
    else if (köpaVad == "4")
    {
        prisPerVara = 95;
    }

    Console.WriteLine("Hur många vill du ha");
    int antal = 0;
    while (antal == 0)
    {
        string num = Console.ReadLine();
        bool success = int.TryParse(num, out antal);
        if (success == false)
        {
            Console.WriteLine("Du behöver skriva en siffra!");
        }
    }

    int slutkost = prisPerVara * antal;

    if (slutkost <= pengar)
    {
        Console.WriteLine("Det funkar");
        pengar -= slutkost;
    }
    else
    {
        Console.WriteLine("Det går inte, du är fattig");
    }
}

Console.WriteLine("Du har inte pengar kvar");
Console.WriteLine("Tryck på vad som helst för att avsluta");
Console.ReadLine();