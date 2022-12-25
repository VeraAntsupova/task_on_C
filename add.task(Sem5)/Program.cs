// See https://aka.ms/new-console-template for more information
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array [i] = new Random().Next(1,31);
}

int CountTriples(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
            count++;
    }

    return count;
}

int CountFours(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }

    return count;
}

string ReleaseArray(int countTriples, int countFours)
{
    string result = "NO";
    if (countFours > countTriples)
    {
        result = "YES";
    }
    return result;
}

Console.WriteLine("ВВедите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Массив: {string.Join(", ", array)}");

int countTruples = CountTriples(array);
int countFours = CountFours(array);

Console.WriteLine($"Результат: {ReleaseArray(countTruples, countFours)}");