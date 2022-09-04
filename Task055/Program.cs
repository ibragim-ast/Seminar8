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

int[,] ChangeRowColumn(int[,] array)
{
    int[,] newArray = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[j,i] = array[i,j];
        }
    }
    return newArray;
}

int[,] matrixArr = CreateMatrix(4, 2, 0, 100);
PrintMatrix(matrixArr);
System.Console.WriteLine();
matrixArr = ChangeRowColumn(matrixArr);
PrintMatrix(matrixArr);


