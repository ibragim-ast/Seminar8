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
    System.Console.WriteLine(length);
    int z = 0;
    for (int i = 0; i < matrixArray.GetLength(1); i++)
    {
        for (int j = 0; j < matrixArray.GetLength(0); j++)
        {
            array[z] = matrixArray[j, i];
            z++;
        }
    }
    return array;
}

//---Подсчет количества повторений чисел в массиве---///
// void FindCountNumber(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         int count = 0;
//         for (int j = 0; j < array.Length; j++)
//         {
//             if (array[i] == array[j])
//                 count++;
//         }
//         if (i < 1)
//         { System.Console.WriteLine($"Число {array[0]} встречается в массиве {count} раз"); }
//         else if (i > 0 && array[i] != array[i + 1])
//         { System.Console.WriteLine($"Число {array[i]} встречается в массиве {count} раз"); }
//         else if (array[i] == array.Length)
//         { System.Console.WriteLine($"Число {array[i]} встречается в массиве {count} раз"); }
//     }
// }

void FindCountNumber(int[] array);
{
    for (int i = 0; i < array.Length; i++)
    {
        int count = 0;
        for (int j = 0; j < array.Length; j++)
        {
            if (array[i] == array[j])
                count++;
        }
        if (i < 1)
        { System.Console.WriteLine($"Число {array[0]} встречается в массиве {count} раз"); }
        else if (array[i] < array.Length -1 && i > 0 && array[i] != array[i + 1])
        { System.Console.WriteLine($"Число {array[i]} встречается в массиве {count} раз"); }
        else if (array[i] == array.Length)
        { System.Console.WriteLine($"Число {array[i]} встречается в массиве {count} раз"); }
    }
}

int[,] matrixArr = CreateMatrix(3, 3, 0, 10);
PrintMatrix(matrixArr);
int[] array = ConverterMatrixToArray(matrixArr);
FindCountNumber(array);



