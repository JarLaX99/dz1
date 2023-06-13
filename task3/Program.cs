Console.Write("Введите число:");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA%2 == 0)
{
    Console.WriteLine($"число {numberA} - четное");
}
else
{
    Console.WriteLine($"число {numberA} - не четное ");
}