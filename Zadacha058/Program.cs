using static System.Console;
using System.Linq;
using MyMetods;
Clear();

/*Задача 58
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.*/

WriteLine("Введите размеры матриц через пробел: ");
WriteLine();
int[] parametrs = ReadLine()!
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
if (parametrs[0] != parametrs[3])
{
    WriteLine("Матрицу A нельзя умножить на матрицу B так как, число столбцов матрицы А не равняется числу строк матрицы В.");
    return;
}
int[,] firstMatrix = MyClass.CreateMatrix(parametrs[0], parametrs[1], 1, 10);
int[,] secondMatrix = MyClass.CreateMatrix(parametrs[2], parametrs[3], 1, 10);
MyClass.PrintMatrix(firstMatrix);
WriteLine();
MyClass.PrintMatrix(secondMatrix);
WriteLine();
int[,] multiplicationMatrix = MultiplicationArray(firstMatrix, secondMatrix);
MyClass.PrintMatrix(multiplicationMatrix);

int[,] MultiplicationArray(int[,] firstArray, int[,] secondArray)
{
    int[,] result = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                result[i, j] += firstArray[i, k] * secondArray[k, j];
            }
        }
    }
    return result;
}
