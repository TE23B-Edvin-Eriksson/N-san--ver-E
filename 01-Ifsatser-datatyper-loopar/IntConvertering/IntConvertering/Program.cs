string input;
int number;


Console.Write("Skriv in ett heltal: "); input = Console.ReadLine();

while (!int.TryParse(input, out number)) ;

Console.WriteLine("Du skrev in ett giltigt heltal: " + number);