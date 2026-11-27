int playerHealth = 100;
int damage = 15;
int roundNumber = 1;

while (playerHealth > 0)
{
    playerHealth -= damage;

    Console.WriteLine($"Round {roundNumber}");
    Console.WriteLine($"Player health: {playerHealth}");

    roundNumber++;
}

Console.WriteLine("Player lost!");
