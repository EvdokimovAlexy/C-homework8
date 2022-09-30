// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
int rows = new Random().Next(2, 6);
int columns = new Random().Next(2, 6);
int[,] arr = FillArray(rows, columns);
Console.WriteLine("Исходный массив");
PrintArray(arr);
Console.WriteLine("Сортировка по строкам: ");
int[] row = new int[columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
        row[j] = arr[i, j];
    BubbleSort(row);
    Insert(i, row, arr);
}
PrintArray(arr);
void Insert(int dim, int[] source, int[,] dest)
{
    for (int k = 0; k < source.Length; k++)
    {
        dest[dim, k] = source[k];
    }
}
int[,] FillArray(int t, int i)
{
    int[,] table = new int[t, i];
    Random random = new Random();
    for (int a = 0; a < t; a++)
    {
        for (int b = 0; b < i; b++)
        {
            table[a, b] = random.Next(0, 9);
        }
    }
    return table;
}
void PrintArray(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            Console.Write(array[a, b] + " ");
        }
        Console.WriteLine();
    }
}
static void BubbleSort(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
        for (int j = 0; j < inArray.Length - i - 1; j++)
        {
            if (inArray[j] < inArray[j + 1])
            {
                int temp = inArray[j];
                inArray[j] = inArray[j + 1];
                inArray[j + 1] = temp;
            }
        }
}

