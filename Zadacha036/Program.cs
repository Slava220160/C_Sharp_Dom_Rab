using static System.Console;
Clear();
//Задача 36
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
WriteLine("Задайте размер массива ");
int ArrayCount = int.Parse(ReadLine());
int[] Array= GetArray(ArrayCount);
WriteLine($"{String.Join(" ", Array)}");
WriteLine($"Сумма элементов, стоящих на нечетных позициях {GetSum(Array)}");
int[] GetArray(int Count)
{
    int[] result = new int[Count];
for (int i = 0; i < Count; i++)
{
    result[i]= new Random().Next(-100,100);
}
    return result;
}
int GetSum(int[] massive)
{
    int Sum=0;
for (int i = 1; i < massive.Length; i+=2)
{
    Sum+=massive[i];
}
    return Sum;
}
