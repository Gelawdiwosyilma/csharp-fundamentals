int playerHealth = 100;
int manticoreHealth = 100;
int playerDamage = 10;
int manticoreDamage = 15;
int roundNumber = 1;

while (playerHealth > 0 && manticoreHealth > 0)
{
    Console.WriteLine($"Round {roundNumber}");

    manticoreHealth -= playerDamage;

    if (manticoreHealth <= 0)
    {
        Console.WriteLine("Player wins!");
        break;
    }

    playerHealth -= manticoreDamage;

    if (playerHealth <= 0)
    {
        Console.WriteLine("Manticore wins!");
        break;
    }

    Console.WriteLine($"Player health: {playerHealth}");
    Console.WriteLine($"Manticore health: {manticoreHealth}");

    roundNumber++;
}
