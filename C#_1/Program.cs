/*Задайте массив заполненный случайными положительными
трёхзначными числами. Напишите программу, которая покажет  
количество чётных чисел в массиве.

[345, 807, 568, 234] -> 2*/

Console.Clear();
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = new int[size];
ArrayRandomNum(num);
Console.WriteLine("Массив: ");
PrintArray(num);
int count = 0;

for (int n = 0; n < num.Length; n++)
if (num[n] % 2 == 0)
count++;

Console.WriteLine($"всего {num.Length} чисел, {count} из них чётные");

void ArrayRandomNum(int[] num)
{
    for(int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] num)
{
    Console.Write("[ ");
    for(int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}