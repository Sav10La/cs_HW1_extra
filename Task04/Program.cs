// Задача 4. Дано N секунд. Вывести время в формате часы:минуты:секунды.

Console.Write("Введите количество секунд: ");
int sec = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(TimeSpan.FromSeconds(sec));