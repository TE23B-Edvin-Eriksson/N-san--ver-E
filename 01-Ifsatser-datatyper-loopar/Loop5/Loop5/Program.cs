int a = 0;

while (a < 5) 
{
    Console.WriteLine("Skriv ett tal:");
    string answer = Console.ReadLine();
    
    int result;
    bool isNumber = int.TryParse(answer, out result);
    
    if (!isNumber)
    {
        Console.WriteLine("Det är inte ett nummber!");
    }

    if (result > 5)
    {
        Console.WriteLine("Högre än 5!");
    }
    else 
    {
        Console.WriteLine("Det är lägre än 5");
    }
    
    a++; 
}

Console.ReadLine();