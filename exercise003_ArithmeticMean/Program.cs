// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int rows = new Random().Next(3, 10);
int columns = new Random().Next(3, 10);

int[,] matrix = new int[rows, columns];
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(10);
        }
    }

for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int m = 0; m < matrix.GetLength(1); m++)
        {
            Console.Write(matrix[k, m] + "\t");
        }
        Console.WriteLine();
    }

for (int k = 0; k < matrix.GetLength(1); k++)
    {
        double result = 0;
        for (int z = 0; z < matrix.GetLength(0); z++)
        {
            result = result+matrix[z,k];
        }
        Console.Write(Math.Round(result/matrix.GetLength(0), 1) + "\t");
    }

Console.WriteLine("-среднее арифметическое каждого столбца");
