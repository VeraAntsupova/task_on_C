// Задайте двумерный массив размером m * n, 
// заполненный случайными вещественными числами

void InputMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    
    }
}
Console.Clear();
Console.Write("Введите размер матрицы: ");
string[] numbers = Console.ReadLine().Split(" ");
double[,] matrix = new double[Convert.ToInt32(numbers[0]), Convert.ToInt32(numbers[1])];
InputMatrix(matrix);
