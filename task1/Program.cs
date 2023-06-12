Console.Write("Введите первое число:");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число:");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine($"первое число больше");
}
if (numberB > numberA)
{
    Console.WriteLine($" второе число больше");
}
else if (numberA == numberB)
{
    Console.WriteLine($"числа  равны");
}