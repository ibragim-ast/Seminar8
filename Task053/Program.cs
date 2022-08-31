// Задача 53. Задайте двумерный массив. 
// Напиши программу, которая поменяет местами первую и последнюю строчки массива.

int[,] CreateMatrix(int row, int column, int min, int max)
{
    int[,] matrixArr = new int[row, column];
    for (int i = 0; i < matrixArr.GetLength(0); i++)
    {
        for (int j = 0; j < matrixArr.GetLength(1); j++)
        {
            matrixArr[i,j] = new Random().Next(min, max);
        }
    }
    return matrixArr;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i,j]}\t");
        }
        System.Console.WriteLine();
    }
}

void SwapRows(int[,] array)
{
    int rowCount = array.GetLength(0);
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[0,i];
        array[0,i] = array[rowCount -1, i];
        array[rowCount -1, i] = temp; 
    }
}

int[,] matrixArr = CreateMatrix(7, 8, 0, 100);
PrintMatrix(matrixArr);
System.Console.WriteLine();
SwapRows(matrixArr);
PrintMatrix(matrixArr);