Console.Write("Введите a :");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b :");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите c :");
double c = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k :");
double k = Convert.ToDouble(Console.ReadLine());
{
    {
        if (a % k == 0)
        {
            Console.WriteLine("k делитель а");
        }
        if (b % k == 0)
        {
            Console.WriteLine("k делитель b");
        }
        if (c % k == 0)
        {
            Console.WriteLine("k делитель c");
        }
    }
    if (k == 0)
    {
        Console.WriteLine("k не может быть 0");
    }
    else
    {
        Console.WriteLine("k не делитель этих чисел");
    }
}


