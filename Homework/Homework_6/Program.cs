// Вы продлили срок сдачи задания до 1 мая, 11:00 +03:00 UTC

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3



/*Console.Write("Введите элементы(через запятую): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
	if (arr[i] > 0)
	{
		count++;
	}
}
 
Console.WriteLine($"Кол-во элементов > 0: {count}");*/


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*Console.Write("Введите k1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
 
double x = -(k1 - k2) / (b1 - b2);
double y = b1 * x + k1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
if(k1 == k2)
         Console.Write("Прямые являются параллельными.");
    else
        Console.WriteLine($"Пересечение в точке: ({x};{y})");*/

