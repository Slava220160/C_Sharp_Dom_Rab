//Задача 2
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.Write($"Максимальное число {number1}");
}
if (number1 == number2)
{
    Console.Write("Числа равны");
}
if (number1 < number2)
{
    Console.Write($"Максимальное число {number2}");
}
Console.WriteLine();
