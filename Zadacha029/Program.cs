using static System.Console;
Clear();
//Задача 29
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] Mass = GetArray(8);
WriteLine($"[{String.Join(", ", Mass)}]");
int[] GetArray(int N)
{
int[] array = new int[N];
for (int i=0; i<N; i++)
{
    array[i] = new Random().Next(0,10);
}
return array;
}