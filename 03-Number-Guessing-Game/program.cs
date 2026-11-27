Console.WriteLine("User 1, please enter a number:");
int input1 = Convert.ToInt32(Console.ReadLine());

Console.Clear();

Console.WriteLine("Guess the number, User 2:");
int input2 = Convert.ToInt32(Console.ReadLine());

int attemptCounter = 0;

while (true)
{
    attemptCounter++;

    if (input2 > input1)
        Console.WriteLine("Guess lower.");
    else if (input2 < input1)
        Console.WriteLine("Guess higher.");
    else
    {
        Console.WriteLine($"You got it in {attemptCounter} attempts!");
        break;
    }

    if (attemptCounter >= 5)
    {
        Console.WriteLine("You lost!");
        break;
    }

    input2 = Convert.ToInt32(Console.ReadLine());
}
