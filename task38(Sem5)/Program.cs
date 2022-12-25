// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Convert.ToDouble(new Random().Next(100, 1000))/ 100;
}

double[] ReleaseArray(double[] array)
{
    double max = array[0];
    double min = array[0];
    double[] result = new double[2];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
        if (min > array[i])
        {
            min = array[i];
        }
    }
    result[0] = max;
    result[1] = min;

    return result;
}
Console.WriteLine("ВВедите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Массив: {string.Join(" | ", array)}");
double[] result = ReleaseArray(array);
Console.WriteLine($"Результат: Max: {result[0]}, Min: {result[1]}");
