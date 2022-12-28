// Пользователь вводит с клавиатуры M чисел
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 100);
}

int ReleaseArray(int[] array)
{
    int count =0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >0 )
        {
            count++;
        }
        
    }

    return count;
}
Console.WriteLine("ВВедите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Массив: {string.Join(" | ", array)}");
Console.WriteLine($"Результат: {ReleaseArray(array)}");
