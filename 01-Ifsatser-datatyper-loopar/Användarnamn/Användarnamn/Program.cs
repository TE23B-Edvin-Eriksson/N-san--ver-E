string username;
string answer1;
string password;
string answer2;

Console.WriteLine("What username do you want");

username = Console.ReadLine();

Console.WriteLine("What password do you want");

password = Console.ReadLine();

Console.WriteLine("Write your username");

answer1 = Console.ReadLine();

Console.WriteLine("Write your password");

answer2 = Console.ReadLine();

if (answer1 == username && password == answer2)
{
    Console.WriteLine("Welcome!");
}
else
{
    Console.WriteLine("Wrong Username or password");
}

Console.ReadLine();
