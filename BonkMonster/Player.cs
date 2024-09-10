public class Player
{
    public string name;
    public int hp = 100;

    public int PlayerAttack(int enemyhealth) {
        Random random = new Random();
        int damage = random.Next(0, 15);

        enemyhealth -= damage;

        return enemyhealth;
    }
}
