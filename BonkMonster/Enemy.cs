using System;

public class Enemy
{
    public Player player;
    public int hp = 100;

    public void EnemyAttack()
    {
        Random random = new Random();
        int damage = random.Next(0, 16);

        Console.WriteLine($"Enemy attacks and deals {damage} damage to {player.name}");

        player.hp -= damage;

        if (player.hp <= 0)
        {
            player.hp = 0;
        }

        Console.WriteLine($"{player.name} HP: {player.hp}");
    }
}