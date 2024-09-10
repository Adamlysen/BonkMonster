using System;



public class Player
{
    public Enemy enemy;
    public string name;
    public int hp = 100;


    public void PlayerAttack()
    {
        Random random = new Random();
        int damage = random.Next(0, 16);

        Console.WriteLine($"{name} attacks and deals {damage} damage to Enemy");

        enemy.hp -= damage;

        if (enemy.hp <= 0)
        {
            enemy.hp = 0;
        }

        Console.WriteLine($"Enemy HP: {enemy.hp}");
    }
}
