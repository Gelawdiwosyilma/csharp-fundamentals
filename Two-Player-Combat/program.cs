
int player1Health = 100;
int player2Health = 100;

Console.WriteLine("Enter Player 1 damage:");
int damage1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Player 2 damage:");
int damage2 = Convert.ToInt32(Console.ReadLine());

while (damage1 <= 0)
{
    Console.WriteLine("Enter valid damage for Player 1:");
    damage1 = Convert.ToInt32(Console.ReadLine());
}

while (damage2 <= 0)
{
    Console.WriteLine("Enter valid damage for Player 2:");
    damage2 = Convert.ToInt32(Console.ReadLine());
}

while (true)
{
    player2Health -= damage1;
    Console.WriteLine($"Player 2 health: {player2Health}");

    if (player2Health <= 0)
    {
        Console.WriteLine("Player 1 wins!");
        break;
    }

    player1Health -= damage2;
    Console.WriteLine($"Player 1 health: {player1Health}");

    if (player1Health <= 0)
    {
        Console.WriteLine("Player 2 wins!");
        break;
    }
}
