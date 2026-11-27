int[] numbers=new int[10];
for (int i=0;i<numbers.Length;i++)
{ 
    Console.WriteLine("enter an integer please");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
int positiveCount = 0;
for (int i=0;i<numbers.Length;i++)
{
    if (numbers[i] > 0)
        positiveCount++;
}
Console.WriteLine($"Console.WriteLine($"There are {positiveCount} positive numbers."););
int negativeCount = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] < 0)
        negativeCount++;
}
Console.WriteLine($"Console.WriteLine($"There are {negativeCount} negative numbers.");");
int zeroCount = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] == 0)
       zeroCount++;
}
Console.WriteLine($"Console.WriteLine($"There are {zeroCount} zeros.");");
