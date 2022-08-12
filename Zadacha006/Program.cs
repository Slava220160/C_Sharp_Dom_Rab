using static System.Console;
Clear();
//Задача 6
//Напишите программу, которая на вход принимает число и выдаёт,
//является ли число чётным (делится ли оно на два без остатка).
WriteLine("Введите число: ");
int number = Convert.ToInt32 (ReadLine());
if(number%2 == 0)
{
    Write("Число чётное");
}
else
{
    WriteLine("Число нечётное");
}
WriteLine();
