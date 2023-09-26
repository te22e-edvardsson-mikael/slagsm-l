
int hp = 500;
int hp2 = 500;
int dmg = 0;
int dmg2 = 0;

Random generator = new Random();

if (hp > 0){
   
int dmg = generator.Next(0, 250);

hp-dmg;

}

else 
{
   
Console.WriteLine("PLAYER 1 VANN")
}


if (hp2 > 0){
   Console.WriteLine("")
int dmg2 = generator.Next(0, 250);
hp2-dmg2;
}
else 
{
   
Console.WriteLine("PLAYER 2 VANN")
}


Console.WriteLine("färdig")

Console.ReadLine();