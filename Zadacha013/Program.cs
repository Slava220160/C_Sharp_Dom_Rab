using static System.Console;
Clear();
//Задача 13
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Write("Введите трёхзначное число: ");
Double number = Convert.ToDouble(ReadLine ());
if (number>99)
{
Double number1= number % 10;
WriteLine($"Третий знак числа {number} - это {number1} ");
}
else
{
WriteLine("Введено число без третьего знака");
}
