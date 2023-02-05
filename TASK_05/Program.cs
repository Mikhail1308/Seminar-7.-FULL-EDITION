// Задайте двумерный массив. Введите элемент, и найдите первое 
// его вхождение, выведите позиции по горизонтали и вертикали, 
// или напишите, что такого элемента нет.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Введенный элемент 2, результат: [1, 4]
// Введенный элемент 6, результат: такого элемента нет.

int[,] CreatArray(int m = 3, int n = 4)
{
    Random rnd = new Random();
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    Console.WriteLine();
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

int NumberInput(string msg)
{
    Console.WriteLine(msg + " > ");
    return Convert.ToInt32(Console.ReadLine());
}

(bool, int, int) FindIndexes(int[,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                return (true, i, j);
            }
        }
    }
    return (false, 0, 0);
}

int[,] resultArray = CreatArray();
PrintArray(resultArray);
int number = NumberInput("Введите число: ");
(bool check, int x, int y) = FindIndexes(resultArray, number);
if (check)
{
    Console.WriteLine($"Введенный элемент {number}, результат: строка {x + 1},  столбец {y + 1}");
}
else
{
    Console.WriteLine($"Данного элемента нет массиве.");
}
Console.WriteLine();

