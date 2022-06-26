// Задача 3. На ввод подаётся рост трёх спортсменов. Расположить их от большего к меньшему.

Console.WriteLine("Введите рост 1-ого спортсмена в см: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите рост 2-ого спортсмена в см: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите рост 3-ого спортсмена в см: ");
int c = Convert.ToInt32(Console.ReadLine());

int max, ave, min;

if(a>b)
{
    if(a>c)
    {
        if(b>c)
        {
            max = a;
            ave = b;
            min = c;
        }
        else
        {
            max = a;
            ave = c;
            min = b;
        }
    }
    else
    {
        max = c;
        ave = a;
        min = b;
    };
}
else if (a>c)
{
    max = b;
    ave = a;
    min = c;
}
else if (b>c)
{
    max = b;
    ave = c;
    min = a;
}
else
{
    max = c;
    ave = b;
    min = a;
}

Console.WriteLine($"{max}, {ave}, {min}");