using static System.Console;
Clear();
//Задача 2
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32 (ReadLine());
WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32 (ReadLine());
if(number1>number2)
{
    Write($"Максимальное число {number1}");
}
if(number1 == number2)
{
    Write("Числа равны");
}
if(number1<number2)
{
    Write($"Максимальное число {number2}");
}
WriteLine();