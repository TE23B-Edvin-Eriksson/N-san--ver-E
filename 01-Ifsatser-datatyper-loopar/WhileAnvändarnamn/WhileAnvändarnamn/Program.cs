string password = "yes";
string answer = "";

while (password != answer)
{
    Console.WriteLine("Write your password");
     answer = Console.ReadLine();
    if (password != answer)
    {
    Console.WriteLine("Wrong Password!");
    }
}
Console.WriteLine("Welcome");
Console.ReadLine();