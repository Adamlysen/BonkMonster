Player player = new();
Enemy enemy = new();


Console.WriteLine("Enter player name:");
player.name = Console.ReadLine();

Console.WriteLine("Press Enter to Start");
Console.ReadLine();

player.PlayerAttack(enemy.hp);
Console.WriteLine(enemy.hp);
Console.ReadLine();

