﻿// Вы продлили срок сдачи задания до 27 апр., 10:00 +03:00 UTC
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

/*int[] CreateRandomArray(int size)
{
	int[] array = new int[size];
	for(int i = 0; i < size; i++)
		array[i] = new Random().Next(100, 1000);
	return array;
}
void ShowArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
		Console.Write(array[i] + " ");
	Console.WriteLine();
}
int QuantityEvenNumbers (int[] array)
{
	int total = 0;
		for (int i = 0; i < array.Length; i++)
		if(array[i] % 2 == 0) total = total + 1;
	return total;
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateRandomArray(size);
ShowArray(newArray);
int result = QuantityEvenNumbers(newArray);
Console.WriteLine($"Количество четных чиссел в массиве равняется {result}");
*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

/*int[] CreateArray(int size, int min, int max)
{
	int[] array = new int[size];
	for(int i = 0; i < size; i++)
		array[i] = new Random().Next(min, max + 1);
	return array;
}
void ShowArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
		Console.Write(array[i] + " ");
	Console.WriteLine();
}
int Summ(int[] array)
{
	int sum = 0;
	int i = 1;
	while(i < array.Length)
	{
		sum = sum + array[i];
		i = i + 2;
	}
	return sum;
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateArray(size, min, max);
ShowArray(newArray);
int result = Summ(newArray);
Console.WriteLine($"Сумма элементов, стоящих в массиве на нечетных позициях, равняется: {result}");*/



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

/*double[] CreateArray(int size, int min, int max)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++) array[i] = Math.Round((new Random().Next(min, max + 1) + new Random().NextDouble()), 2);
    return array;
}
void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
double MaxMin(double[] array)
{
    double max1 = array[0];
    double min1 = array[0];
        
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min1) 
            min1 = array[i];
        else if(array[i] > max1) 
            max1 = array[i];
    }
    double diff = max1 - min1;
    return Math.Round(diff, 2);
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());
double[] newArray = CreateArray(size, min, max);
ShowArray(newArray);
double result = MaxMin(newArray);
Console.WriteLine($"Разница между max и min значениями элементов массива равняется {result}");*/