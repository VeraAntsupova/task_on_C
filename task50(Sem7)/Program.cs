// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве и
// возвращает значение этого элемента или же указание, что такого элемента нет
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

string ReleaseMatrix(int[,] matrix, int line, int col)
{
    if (matrix.GetLength(0) < line || matrix.GetLength(1) < col)
    {
        return "такой позиции в массиве нет";
    }

    return Convert.ToString(matrix[line, col]);
}

Console.Clear();
int[,] matrix = new int[4, 3];
Console.WriteLine("Двумерный массив: ");
InputMatrix(matrix);
Console.Write("Введите пизцию: ");

string[] numbers = Console.ReadLine().Split(" ");

Console.WriteLine();
Console.WriteLine("Результат:");
Console.WriteLine(ReleaseMatrix(matrix, int.Parse(numbers[0]), int.Parse(numbers[1])));
