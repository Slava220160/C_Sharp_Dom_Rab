using static System.Console;
Clear();
//Задача 8
//Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.
WriteLine("Введите число: ");
int number = Convert.ToInt32 (ReadLine());
int i=1;
while(i<=number)
{
    if(i%2 == 0)
    {
        Write($"{i}, ");
    }
    i++;
}
WriteLine();
