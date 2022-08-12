using static System.Console;
Clear();
//Задача 4
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32 (ReadLine());
WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32 (ReadLine());
WriteLine("Введите число 3: ");
int number3 = Convert.ToInt32 (ReadLine());

if(number1>=number2)
{
   if(number1>=number3)
   {
        Write($"Максимальное число {number1}");
   }
}
else
{
    if(number2>=number3)
        {
            Write($"Максимальное число {number2}");
        }   
    else 
    {
        Write($"Максимальное число {number3}");
    }
}
WriteLine();
