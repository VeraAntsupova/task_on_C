// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
void ReleaseMatrix(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }

        Console.Write($"{sum / matrix.GetLength(0)} ");
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
string[] numbers = Console.ReadLine().Split(" ");
int[,] matrix = new int[Convert.ToInt32(numbers[0]), Convert.ToInt32(numbers[1])];
InputMatrix(matrix);
ReleaseMatrix(matrix);