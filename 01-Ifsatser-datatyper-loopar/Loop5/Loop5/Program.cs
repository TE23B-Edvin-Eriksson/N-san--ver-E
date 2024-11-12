int a = 0;

while (a < 5) 
{
    Console.WriteLine("Skriv ett tal:");
    string answer = Console.ReadLine();
    
    int result;
    bool isNumber = int.TryParse(answer, out result);
    
    if (!isNumber)
    {
        Console.WriteLine("Thats not a number");
    }

    if (result > 5)
    {
        Console.WriteLine("Higher than 5!");
    }
    
    a++; 
}

Console.ReadLine();