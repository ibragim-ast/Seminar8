// Задача 57. Задайте массив. Выведите количество одинаковых элементов массива
// Одномерный массив

int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    Array.Sort(array);
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void FindCountNumber(int[] array)
{
    int count = 0;
   
    for (int i = 0; i < array.Length; i++)
    {
        count = 0;
        for (int j = 0; j < array.Length; j++)
        {
            if (array[i] == array[j])
                count++;
        }
        if (i < 1)
        {System.Console.WriteLine($"Число {array[0]} встречается в массиве {count} раз");}
        else if (i > 0 && array[i] != array[i -1])
        {System.Console.WriteLine($"Число {array[i]} встречается в массиве {count} раз");}
    }  
}

int[] array = CreateArray(10, 0, 10);
PrintArray(array);
FindCountNumber(array);

