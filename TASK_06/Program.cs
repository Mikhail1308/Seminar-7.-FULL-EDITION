// Задача 5: Задайте двумерный массив. Найдите максимальный элемент массива
// и среднее арифметическое всех элементов массива.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Максимальный элемент массива 9
// Среднее арифметическое 4.25

int[,] CreatArray(int m = 3, int n = 4)
{
    Random rnd = new Random();
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
    }
    Console.WriteLine();
}

int FindMax(int[,] array)
{
    int max = array[0, 0];
    foreach (int item in array)
    {
        if (item > max)
            {
                max = item;
            }
    }
    // for (int i = 0; i < array.GetLength(0); i++)
    // {
    //     for (int j = 0; j < array.GetLength(1); j++)
    //     {
    //         if (array[i, j] > max)
    //         {
    //             max = array[i, j];
    //         }
    //     }
    return max;
}

double FindAverage(int[,] array)
{
    double sum = 0;
    foreach (int item in array)
    {
        sum += item;
    }
    return sum / array.Length;
}

int[,] baseArray = CreatArray();
PrintArray(baseArray);
int maxResult = FindMax(baseArray);
Console.WriteLine($"Максимальное значение в массиве: {maxResult}");
double averageResult = FindAverage(baseArray);
Console.WriteLine($"Среднее арифметическое чисел массива: {averageResult:F2}");