// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов

void InPutMatrix(int[,] matrix)
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
int[] ReleaseMatrix(int[,] matrix)
{
    int[] temp = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        temp[i] = sum;
    }

    return temp;
}

int MinSumLineInMatrix(int[] sumLine)
{
    int min = sumLine[0];
    int index = 0;
    for (int i = 0; i < sumLine.GetLength(0); i++)
    {
        if (min > sumLine[i])
        {
            min = sumLine[i];
            index = i;
        }
    }

    return index + 1;
}

Console.Write("Введите размеры матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
InPutMatrix(matrix);
int[] sumLine = ReleaseMatrix(matrix);
Console.WriteLine($"Суммы в строках: {string.Join(", ", sumLine)}");
Console.WriteLine($"Наименьшая сумма в строке: {MinSumLineInMatrix(sumLine)}");
