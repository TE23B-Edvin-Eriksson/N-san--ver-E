int hemligtTal = Random.Shared.Next(1,11);
int gissning = -1;

Console.WriteLine("Välkommen till Gissa Siffran! Jag har valt ett tal mellan 1 och 10.");

while (gissning != hemligtTal)
{
    Console.Write("Skriv in din gissning: ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out gissning))
    {
        if (gissning < hemligtTal)
        {
            Console.WriteLine("För lågt numner!");
        }
        else if (gissning > hemligtTal)
        {
            Console.WriteLine("För högt nummer!");
        }
        else
        {
            Console.WriteLine("Rätt svar!");
            Console.ReadLine();
        }
    }
    else
    {
        Console.WriteLine("Det är inte ett nummer!!");
    }
}