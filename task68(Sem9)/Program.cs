// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.


int ackerman(int n, int m)
{
    while (n != 0)
    {
        if (m == 0)
            m = 1;
        else
            m = ackerman(n, m - 1);
        n = n - 1;
    }

    return m + 1;
}

Console.Clear();

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Результат (N:{n}, M:{m}):{ackerman(m, n)}");
