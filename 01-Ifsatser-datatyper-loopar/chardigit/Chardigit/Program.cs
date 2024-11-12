int a = 1;

while (a > 0)
{
    Console.WriteLine("Skriv ett nummer: ");
    string svar = Console.ReadLine();
    if (int.TryParse(svar, out int number))
    {
        Console.WriteLine("Du har skrivit ett nummer : " + number);
        a--;
    }
    else
    {
        Console.WriteLine("Det är inte ett nummer!");
    }
}
Console.ReadLine();