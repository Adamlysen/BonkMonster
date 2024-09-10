Player player = new Player();
Enemy enemy = new Enemy();

player.enemy = enemy;
enemy.player = player;

bool playerWin = false;
bool enemyWin = false;
bool playerAlive = true;
bool enemyAlive = true;

Console.WriteLine("Enter player name:");
player.name = Console.ReadLine();

Console.WriteLine("Press Enter to Start");
Console.ReadLine();


while (playerAlive && enemyAlive)
{

    enemy.EnemyAttack();


    if (player.hp <= 0)
    {
        playerAlive = false;
        enemyWin = true;
        break;
    }

    Console.ReadLine();


    player.PlayerAttack();


    if (enemy.hp <= 0)
    {
        enemyAlive = false;
        playerWin = true;
        break;
    }

    Console.ReadLine();
}


if (playerWin)
{
    Console.WriteLine($"{player.name} wins!");
}
else if (enemyWin)
{
    Console.WriteLine("Enemy wins!");
}


Console.ReadLine();