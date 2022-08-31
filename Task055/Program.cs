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

void ChangeRowColumn(int[,] array)
{
    int newRow = array.GetLength(0);
    int newColumn = array.GetLength(1);
    if (newColumn != newRow)
    {System.Console.WriteLine("Некорректный размер матрицы");
    return;}
    int[,] newArray = new int[newRow, newColumn];
    for (int i = 0; i < newColumn; i++)
    {
        for (int j = 0; j < newRow; j++)
        {
            newArray[i,j] = array[j,i];
            System.Console.Write($"{newArray[i,j]}\t");
        }
        System.Console.WriteLine();
    }
}


int[,] matrixArr = CreateMatrix(4, 4, 0, 100);
PrintMatrix(matrixArr);
System.Console.WriteLine();
ChangeRowColumn(matrixArr);

