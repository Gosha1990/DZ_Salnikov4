// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// double result = 0;

Console.WriteLine("Количество строк: rows ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество столбцов: cols ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] variable = new int[rows, cols];
GetMatrix(variable);
for (int j = 0; j < variable.GetLength(1); j++)
{
    double result = 0;
    for (int i = 0; i < variable.GetLength(0); i++)
    {
        result = (result + variable[i, j]);
    }
    result = result / rows;
    Console.Write($"Средние {result } \n");
  
}
Console.WriteLine();
PrintMatrix(variable);

void GetMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
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


