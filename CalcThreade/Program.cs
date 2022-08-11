//Вычислить кол-во числел на промежутке от 0 до указанного пользователем
//в которых сумма цифр числа кратна последней цифре числа
while (Console.ReadLine != null)
{
    Console.WriteLine("Введите число:");
    int source;
    int countSum = 0;
    if (int.TryParse(Console.ReadLine(), out source))
    {

        Parallel.For(0, source, i =>
        {
            if (CalcMethod(i))
            {
                Interlocked.Increment(ref countSum);
            }
        });
        Console.WriteLine($"Всего чисел: {countSum}");
    }
    else
    {
        Console.WriteLine("Введите корректное число");
    }


    static bool CalcMethod(int i)
    {
        if (i % 10 == 0)
        {
            return true;
        }

        int n = i;
        int sumDigit = 0;

        do
        {
            sumDigit += (n % 10);
            n /= 10;
        }
        while (n >= 10);

        sumDigit += (n % 10);

        if (sumDigit % (i % 10) == 0)
        {
            return true;
        }
        return false;
    }

}
