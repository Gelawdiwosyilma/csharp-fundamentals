int[] numbers = new int[10];

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine("Enter an integer:");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

int largestNumber = numbers[0];
int secondLargestNumber = int.MinValue;

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > largestNumber)
    {
        secondLargestNumber = largestNumber;
        largestNumber = numbers[i];
    }
    else if (numbers[i] > secondLargestNumber && numbers[i] < largestNumber)
    {
        secondLargestNumber = numbers[i];
    }
}

Console.WriteLine($"Largest: {largestNumber}");
Console.WriteLine($"Second largest: {secondLargestNumber}");
