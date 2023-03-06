// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.



Console.WriteLine("Количество строк: rows ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество столбцов: cols ");
int cols = Convert.ToInt32(Console.ReadLine());
int sum = 0;

int[,] variable = new int[rows, cols];

GetMatrix(variable);

for (int i = 0; i < variable.GetLength(0); i++)
{
    for (int j = 0; j < variable.GetLength(1); j++)
    {
        if (i == j)
        {
            sum = sum + variable[i, j];
          
        }
    }
}
  Console.WriteLine($"Сумма главной диагонали: {sum}");

Console.WriteLine();
PrintMatrix(variable);
void GetMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-10, 10);
        }
    }
 }
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}



