﻿using static System.Console;
Clear();
//Задача 43
//Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

WriteLine("Введите значение b1");
double b1 = int.Parse(ReadLine());
WriteLine("Введите значение k1");
double k1 = int.Parse(ReadLine());
WriteLine("Введите значение b2");
double b2 = int.Parse(ReadLine());
WriteLine("Введите значение k2");
double k2 = int.Parse(ReadLine());
double x = (b2 - b1)/(k1-k2);
double y = k1 * x + b1;
WriteLine($"Кординаты точки пересечения прямых: ({x:f1} ; {y:f1})");