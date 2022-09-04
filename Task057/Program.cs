// Задача 57. Задайте массив. Выведите количество одинаковых элементов массива
// Двумерный массив

//---Создание матрицы с рандомным заполнением---//
int[,] CreateMatrix(int row, int column, int min, int max)
{
    int[,] matrixArr = new int[row, column];
    for (int i = 0; i < matrixArr.GetLength(0); i++)
    {
        for (int j = 0; j < matrixArr.GetLength(1); j++)
        {
            matrixArr[i, j] = new Random().Next(min, max);
        }
    }
    return matrixArr;
}

//---Печать матрицы---//
void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

//---Конвертирование двумерного массива в одномерный---//
int[] ConverterMatrixToArray(int[,] matrixArray)
{
    int length = matrixArray.GetLength(0) * matrixArray.GetLength(1);
    int[] array = new int[length];
    int z = 0;
    for (int i = 0; i < matrixArray.GetLength(1); i++)
    {
        for (int j = 0; j < matrixArray.GetLength(0); j++)
        {
            array[z] = matrixArray[j, i];
            z++;
        }
    }
    Array.Sort(array);
    return array;
}

//---Печать одномерного массива---//
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");

    }
    System.Console.WriteLine();
}

void FindCountNumber(int[] array)
{
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == array[i - 1])
        {
            count++;
        }
        else
        {
            System.Console.WriteLine($"Число {array[i - 1]} встречается {count} раз");
            count = 1;
        }

        if (i == array.Length - 1)
        { System.Console.WriteLine($"Число {array[i]} встречается {count} раз"); }
    }
}

int[,] matrixArr = CreateMatrix(3, 3, 0, 12);
PrintMatrix(matrixArr);
int[] array = ConverterMatrixToArray(matrixArr);
PrintArray(array);
FindCountNumber(array);



