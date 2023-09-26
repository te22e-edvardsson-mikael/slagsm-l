
int hp = 500;
int hp2 = 500;
int dmg = 0;
int dmg2 = 0;

string name = "";

Console.ReadLine();

Console.WriteLine($"welcome {name} you'll be going up against villan");

Console.ReadLine();

Random generator = new Random();
Console.WriteLine("Player A mot player B båda har 500 hp");
Console.WriteLine("Samt gör dmg mellan 0-250");

Console.ReadLine();

if (hp > 0){
   
int dmg = generator.Next(0, 250);

hp-= dmg;
}

else 
{
   
Console.WriteLine("PLAYER 1 VANN")
}


if (hp2 > 0){
   Console.WriteLine("du har "hp2"hp kvar");
int dmg2 = generator.Next(0, 250);
hp2-dmg2;
}
else 
{
   
Console.WriteLine("PLAYER 2 VANN")
}


Console.WriteLine("färdig")

Console.ReadLine();