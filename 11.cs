Console.Write("Введите сколько минут вы говорили в этот месяц:");
double m = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите доступные тарифом количество минут:");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите цену тарифа за месяц :");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите цену за каждую минуту разговоров вне трафика:");
double c = Convert.ToDouble(Console.ReadLine());
double res;
{
    if (m <= a)
    {
        res = b;

    }
    else
    {

        res = (m - a) * c + b;
    }
    Console.WriteLine($"За этот месяц вы должны заплатить: {res}");
}
