using static System.Console;
Clear();
//Задача 23
// Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N
Write("Введите число: ");
int N = int.Parse(ReadLine()!);
int i = 1;

while (i <= N)
    {
    Write($"{i*i*i} ");
    i++;
    }
WriteLine();
