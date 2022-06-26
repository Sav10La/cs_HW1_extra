// Задача 2. Даны два числа a, b, такие что a < b. Вывести на экран сколько раз число a поместиться в числе b.

Console.Write("Введите число a: ");
double a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число b больше числа a: ");
double b = Convert.ToInt32(Console.ReadLine());

double division = b/a;

if(a<b)
{
    Console.WriteLine($"Число a поместится в числе b {(Math.Truncate(division))} раз");
}
else
{
    Console.WriteLine("Число a должно быть меньше числа b");
}