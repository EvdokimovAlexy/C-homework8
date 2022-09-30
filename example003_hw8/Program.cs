//Задача 58. Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

Console.WriteLine("Введите число строк первой матрицы: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число колонок первой матрицы: ");
int columns1 = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[rows1, columns1];
Console.WriteLine("Введите число строк второй матрицы: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число колонок второй матрицы: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
int[,] matrix2 = new int[rows2, columns2];
if (matrix1.GetLength(1) != matrix2.GetLength(0))
{
    Console.WriteLine("Количество столбцов первой матрицы и строк второй матрицы должно быть одинаковым");
}
else
{
    FillArrayRandomNumbers(matrix1);
    FillArrayRandomNumbers(matrix2);
    PrintArray(matrix1);
    Console.WriteLine();
    PrintArray(matrix2);
    Console.WriteLine();
    Console.WriteLine("Результат произведения: ");
    Console.WriteLine();
    int[,] multiplicationOfMatrixes = GetMatrixMultiplication(matrix1, matrix2);
    PrintArray(multiplicationOfMatrixes);
}
int[,] GetMatrixMultiplication(int[,] matr1, int[,] matr2)
{
    int[,] result = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            for (int k = 0; k < matr1.GetLength(1); k++)
            {
                result[i, j] += matr1[i, k] * matr2[k, j];
            }
        }
    }
    return result;
}
void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
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