// Задача 1. Пользователь вводит число N (N > 0). Программа должна вывести N единиц на экран.
// N = 4 -> 1, 1, 1, 1
// N = 2 -> 1, 1

Console.WriteLine("Введите число больше 0: ");
int i = Convert.ToInt32(Console.ReadLine());
int count = 1;
if (i > 0)
{
    while (i >= count) {
        if(i == count)
        {
            Console.Write ("1");
        }
        else
        {
            Console.Write ("1, ");
        }
        count++;
    }
}
else {
    Console.Write("Вы ввели число меньше 0");
}