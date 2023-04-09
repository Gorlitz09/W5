/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

Console.Clear();
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = new int[size];
RandomNum(num);
Console.WriteLine("Массив: ");
PrintArray(num);
int sum = 0;

for (int i = 0; i < num.Length; i+=2)
    sum = sum + num[i];

    Console.WriteLine($"всего {num.Length} чисел, сумма элементов с нечётными значениями = {sum}");

void RandomNum(int[] num)
{
    for (int n = 0; n < num.Length; n++)
        {
            num[n] = new Random().Next(-15,15);
        }
}
void PrintArray(int[] num)
{
    Console.Write("[ ");
    for(int n = 0; n < num.Length; n++)
        {
            Console.Write(num[n] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}