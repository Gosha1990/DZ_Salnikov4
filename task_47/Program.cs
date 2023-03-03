// Задача 47. Задайте двумерный массив размером m×n,
//  заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9




 double[,] GetMatrix(int rows, int cols)
{
    double[,] matrix = new double[rows, cols] ;  //[строчка. столбец]
    for (int i = 0; i < rows; i++)// строчки; rows = matrix.GetLenght(0)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = Math.Round(10 * (new Random().NextDouble()), 1);
        }
    }
    return matrix;
}
void PrintMatrix( double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int m = 0; m < matr.GetLength(1); m++)
        {
            Console.Write(matr[i, m] + "\t");
        }
        Console.WriteLine();
    }
}
 double[,] resultMatrix = GetMatrix(3, 4);
PrintMatrix(resultMatrix);

