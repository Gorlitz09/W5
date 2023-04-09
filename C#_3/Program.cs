/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

Console.Clear();
Console.WriteLine("Укажите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Random rand = new Random();
for (int i = 0; i < n; i++)
{
    array[i] = rand.Next(-10, 101);
    Console.Write($" {array[i]}, ");
}
int min = 0;
int max = 0;
foreach (int i in array)
{
    if (min > i) min = i;
    if (max < i) max = i;
}
Console.WriteLine($"Максимальный элеммент массива: {max}");
Console.WriteLine($"Минимальный элемент массива: {min}");
Console.WriteLine($"Разница межну максимальным и минимальным элементом массива: {max - min}");