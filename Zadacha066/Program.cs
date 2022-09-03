using static System.Console;
using System.Linq;
Clear();

/*Задача 66
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
в промежутке от M до N.*/

WriteLine("Введите число M");
int numberM = int.Parse(ReadLine()!);
WriteLine("Введите число N");
int numberN = int.Parse(ReadLine()!);
WriteLine($"{GetSumElements(numberM, numberN)}");

int GetSumElements(int number1, int number2)
{
    if (number1 == number2) return number2;
    else if (number1 > number2) return number2 + GetSumElements(number1, number2 + 1);
    else return number1 + GetSumElements(number1 + 1, number2);
}
