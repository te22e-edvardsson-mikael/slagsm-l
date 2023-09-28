
using System.Threading.Tasks.Dataflow;

int hp1 = 500;
int hp2 = 500;

Console.WriteLine("skriv ditt namn");

string name = Console.ReadLine();

Console.WriteLine($"welcome {name} you'll be going up against villan");

Console.ReadLine();

Random generator = new Random();
Console.WriteLine("Player A mot player B båda har 500 hp");
Console.WriteLine("Samt gör dmg mellan 0-250");

Console.ReadLine();

if (hp2 > 0 && hp1 > 0)
{

   Console.WriteLine($"Ditt {hp1}hp, klicka 'enter' för att fortsätta");
   int dmg2 = generator.Next(0, 250);
   hp1 -= dmg2;

   Console.WriteLine($"Du tog {dmg2} skada och har nu {hp1}hp kvar");
   Console.ReadLine();

   Console.WriteLine("Slå tillbaka!");
   int dmg1 = generator.Next(0, 250);
   hp2 -= dmg1;

   Console.WriteLine($"Du gjorde {dmg1} skada och har villan har {hp2}hp kvar");
   Console.ReadLine();
}


if (hp2 < 0){
Console.WriteLine("VILLAN VANN");
}

if (hp1 < 0){
Console.WriteLine($"{name} VANN");
}

else{
Console.WriteLine($"Ni Båda suger");
}

Console.ReadLine();

