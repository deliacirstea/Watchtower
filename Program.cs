Console.Write("Feed an X value to the program: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Feed an Y value to the program: ");
int y = int.Parse(Console.ReadLine());

if (x < 0 && y > 0)
{
    Console.WriteLine("The enemy is in the NorthWest!");
}
else if (x == 0 && y > 0)
{
    Console.WriteLine("The enemy is in the North!");
}
else if (x > 0 && y > 0)
{
    Console.WriteLine("The enemy is in the NorthEast!");
}
else if (x < 0 && y == 0)
{
    Console.WriteLine("The enemy is in the West!");
}
else if (x > 0 && y == 0)
{
    Console.WriteLine("The enemy is in the East!");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("The enemy is in the SouthWest!");
}
else if (x == 0 && y < 0)
{
    Console.WriteLine("The enemy is in the South!");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("\nThe enemy is in the SouthEast ");
}
else
{
    Console.Beep();
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("\n\t\tTHE ENEMY IS HERE!");
}
Console.ReadLine();