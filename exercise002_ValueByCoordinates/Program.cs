// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] FillArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(10);
        }
    }
    return matrix;
}


void PrintArray(int[,] inputMatrix)
{
    for (int k = 0; k < inputMatrix.GetLength(0); k++)
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++)
        {
            Console.Write(inputMatrix[k, m] + "\t");
        }
        Console.WriteLine();
    }
}

int columns = new Random().Next(3, 10);
int rows = new Random().Next(3, 10);
int[,] resultMatrix = FillArray(rows, columns);
PrintArray(resultMatrix);

Console.Write("Введите номер строки: ");
int rowsNumber = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите номер столбца: ");
int columnsNumber = Convert.ToInt32(Console.ReadLine()) - 1;

if (rowsNumber > rows || columnsNumber > columns) Console.WriteLine($"Значения элемнта в массиве на позиции {rowsNumber+1}, {columnsNumber+1} -> не существует");

else Console.WriteLine($"Значение элемнта в массиве на позиции {rowsNumber+1}, {columnsNumber+1} -> {resultMatrix[rowsNumber, columnsNumber]}");