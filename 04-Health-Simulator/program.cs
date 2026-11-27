int playerHealth = 100;

Console.WriteLine("Enter the damage:");
int damage = Convert.ToInt32(Console.ReadLine());

while (damage <= 0)
{
    Console.WriteLine("Invalid damage. Enter a positive number:");
    damage = Convert.ToInt32(Console.ReadLine());
}

while (playerHealth > 0)
{
    playerHealth -= damage;
    Console.WriteLine($"Your health is {playerHealth}");
}

Console.WriteLine("You lost!");
