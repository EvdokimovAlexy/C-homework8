// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int rows = new Random().Next(3, 3);
int columns = new Random().Next(3, 3);
int[,] array = new int[rows, columns];
FillArrayRandomNumbers(array);
PrintArray(array);
Console.WriteLine("---------------------------");
int[] row = new int[columns];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        row[i] += array[i, j];
    }
}
FindMinSumLine(row);
Console.WriteLine();
Console.WriteLine();
void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    Console.WriteLine();
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void FindMinSumLine(int[] arr)
{
    int minElement = arr[0];
    int minIndex = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (minElement > arr[i])
        {
            minElement = arr[i];
            minIndex = i;
        }
    }
    Console.WriteLine($"Номер строки {minIndex + 1}");
}