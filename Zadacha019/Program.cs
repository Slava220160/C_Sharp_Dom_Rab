using static System.Console;
Clear();
//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Write("Введите пятизначное число: ");
int N = int.Parse(ReadLine()!);

int N1 = N / 10000;
int N2 = N / 1000 % 10;
int N4 = N / 10 % 10;
int N5 = N % 10; 

string num1 = $"{N1}{N2}";
int result1 = int.Parse(num1);

string num2 = $"{N5}{N4}";
int result2 = int.Parse(num2);

if (result1 == result2)

 WriteLine($"Число {N} является палиндромом.");

else

WriteLine($"Число {N} не является палиндромом.");
