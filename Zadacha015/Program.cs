using static System.Console;
Clear();
//Задача 15
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.
int day = 0;

Write("Введите число от 1 до 7: ");
day = int.Parse(ReadLine());

if (day < 6)
    WriteLine("Это рабочий день");

else 
    WriteLine("Это выходной");
