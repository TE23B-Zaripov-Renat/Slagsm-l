while (true)
{

int hp = Random.Shared.Next(50, 101);
Console.WriteLine(hp);
Console.ReadLine();
}


Console.WriteLine("Skriv ditt namn");
string name = Console.ReadLine();

while (name == "")
{
    Console.WriteLine("Du kan ju inte bara trycka enter, dumhuvve");
    Console.WriteLine("Försök igen:");
    name = Console.ReadLine();
}



Console.ReadLine();
