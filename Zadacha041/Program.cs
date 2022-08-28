using static System.Console;
Clear();
//Задача 41
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
WriteLine("Введите числа через пробел: ");
int[] array = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
WriteLine(String.Join(" ", array));
WriteLine($"Чисел больше нуля: {CountPositive(array)}");
int CountPositive(int[] mass)
    {
        int count = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            count = mass[i] > 0 ? count + 1 : count + 0;
        }
        return count;
    }