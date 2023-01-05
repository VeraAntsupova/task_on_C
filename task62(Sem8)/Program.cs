// Напишите программу, которая заполнит спирально массив 4 на 4.

void InPutMatrix(int[,] matrix, int n)
{
    int i = 0,
        j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do
        {
            matrix[i, j++] = value++;
        } while (++k < n - 1);
        for (k = 0; k < n - 1; k++)
            matrix[i++, j] = value++;
        for (k = 0; k < n - 1; k++)
            matrix[i, j--] = value++;
        for (k = 0; k < n - 1; k++)
            matrix[i--, j] = value++;
        ++i;
        ++j;
        if (n < 2)
        {
            n = 0;
        }
        else
        {
            n = n - 2;
        }
    }
}

void OutPutMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10)
            {
                Console.Write($"0{matrix[i, j]} ");
            }
            else
                Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int len = 4;
int[,] matrix = new int[len, len];
InPutMatrix(matrix, len);
OutPutMatrix(matrix);
