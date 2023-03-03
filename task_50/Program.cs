// Задача 50. Напишите программу, которая на вход принимает
//  позиции элемента в двумерном массиве, и возвращает значение 
//  этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1(строчка) 7 (столбец) -> такого числа в массиве нет




Console.WriteLine("Вводим номер строки: rows ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводим номер столбца: cols ");
int cols = Convert.ToInt32(Console.ReadLine());



int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
          
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matr)
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



int[,] resultMatrix = GetMatrix(3, 4, 0, 10);
PrintMatrix(resultMatrix);

    if (rows < 0 | rows > resultMatrix.GetLength(0) - 1 | cols < 0 | cols > resultMatrix.GetLength(1) - 1)
{
Console.WriteLine("Элемент не существует  ");
}
    else
{
    Console.WriteLine("Значение элемента массива = {0}",resultMatrix[rows, cols]);
}
