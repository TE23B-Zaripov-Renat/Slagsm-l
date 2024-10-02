int RonaldoHp = 100;
int MessiHp = 100;

string heroName = "RONALDO";
string villainName = "MESSI";

while (RonaldoHp > 0 && MessiHp > 0)
{
Console.WriteLine("\n ¤==---- NY RUNDA ----==¤");
Console.WriteLine($"{heroName}: {RonaldoHp}  {villainName}: {MessiHp}\n");
Console.ReadLine();

int RonaldoDamage = Random.Shared.Next(20);
MessiHp -= RonaldoDamage;
MessiHp = Math.Max(0, MessiHp);

Console.WriteLine($"{heroName} gör {RonaldoDamage} skada på {villainName}");


  int MessiDamage = Random.Shared.Next(20);
  RonaldoHp -= MessiDamage;
  RonaldoHp = Math.Max(0, RonaldoHp);
  Console.WriteLine($"{villainName} gör {MessiDamage} skada på {heroName}");

 
}

 if (RonaldoHp == 0 && MessiHp == 0 )
  {
    Console.WriteLine("Tyvärr blev det oavgjort, men du kan alltid spela en gång till!");
  }

  else if (RonaldoHp < MessiHp)
  {
    Console.WriteLine("Tyvärr har Messi vunnit. Victory!");
  }

  else if (RonaldoHp > MessiHp)
  {
    Console.WriteLine("Grattis Ronaldo har vunnit. Victory!");
  }

Console.WriteLine("Tryck på valfri knapp för att avsluta.");


Console.ReadLine();



// while (true)
// {

// int hp = Random.Shared.Next(50, 101);
// Console.WriteLine(hp);
// Console.ReadLine();
// }


// Console.WriteLine("Skriv ditt namn");
// string name = Console.ReadLine();

// while (name == "")
// {
//     Console.WriteLine("Du kan ju inte bara trycka enter, dumhuvve");
//     Console.WriteLine("Försök igen:");
//     name = Console.ReadLine();
// }



