Console.Write("Введите первое число:");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число:");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число:");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB && numberA > numberC)
{
    Console.WriteLine($"первое число больше");
}
if (numberB > numberA && numberB > numberC)
{
    Console.WriteLine($" второе число больше");
}
if (numberC > numberA && numberC > numberB)
{
    Console.WriteLine("Третье число больше");
}
else if (numberA == numberB && numberB ==  numberC)
{
    Console.WriteLine($"числа  равны");
}