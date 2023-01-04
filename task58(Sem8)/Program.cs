// See https://aka.ms/new-console-template for more information

void InPutMatrixA(int[,] matrix)
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

void InPutMatrixB(int[,] matrix)
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

int[,] ResultMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[2, 2];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixB.GetLength(0); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k,j];
            }
        }
    }
    return matrixC;
}

void OutPutMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Матрица А: ");
int[,] matrixA = new int[2, 2];
InPutMatrixA(matrixA);

Console.WriteLine("Матрица B: ");
int[,] matrixB = new int[2, 2];
InPutMatrixB(matrixB);

int[,]matrixC = ResultMatrix(matrixA, matrixB);

Console.WriteLine("Результат: ");
OutPutMatrix(matrixC);
