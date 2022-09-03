using static System.Console;
using System.Linq;
Clear();

/*Задача 68
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.*/

WriteLine("Введите первое неотрицательное число M");
int numberM = int.Parse(ReadLine()!);
WriteLine("Введите второе неотрицательное число N");
int numberN = int.Parse(ReadLine()!);
WriteLine($"{FunctionAkkerman(numberM, numberN)}");

int FunctionAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m != 0 && n == 0) return FunctionAkkerman(m - 1, 1);
    else return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
}