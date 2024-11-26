
//1
//List<string> leksaker = new List<string> { "Teddybjörn", "Lego", "Docka", "Actionfigur", "Radiostyrd bil" };

//2

//List<string> leksaker = new List<string> { "Teddybjörn", "Lego", "Docka", "Actionfigur", "Radiostyrd bil" };
//
//foreach (string leksak in leksaker)
//        {
//            Console.WriteLine(leksak);
//        }
//
//Console.ReadLine();


//3
//List<string> klasskompisar = new List<string> { "Gustav", "David", "Sandor", "Kevin", "Renat" };

//Console.ReadLine();

//4

//int[] integerArray = { 5, 6, 7, 8, 9 };
//
//foreach (int number in integerArray)
//{
//    Console.WriteLine(number);
//}
//Console.ReadLine();

//5
// List<int> siffror = [1,2,3,4,5];
// List<string> namn = ["Sandor", "Renat", "Gustav", "Kevin", "David"];
// List<string> leksak = ["Teddybjörn", "Lego", "Docka", "Actionfigur", "Radiostyrd bil"];
// for(int n=0; n<5;)
// {
//     Console.WriteLine(namn[n] + " ger " + leksak[n] + " betyget " + siffror[n]);
//     n++;
// }

//6

//List<string> cities = [];




// 7

List<string> cities = [];
bool Running = true;
while (Running)
{
    Console.WriteLine("Write a city.");
    string svar = Console.ReadLine();
    if (svar.ToLower() == "exit")
    {
        Running = false;
    }
    else
    {
        cities.Add(svar);
    }
}
Console.WriteLine("------");
foreach (string city in cities)
{
    Console.WriteLine(city);
}
Console.WriteLine("------");
Console.ReadLine();