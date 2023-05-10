// Вы продлили срок сдачи задания до 11 мая, 10:00 +03:00 UTC
// Урок 9. Рекурсия

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
integers(num, i);
void integers(int n, int i)
{
    if (i > n) return;
    
    else
    {
        integers(n, i + 1);
        Console.Write(i + " ");
    }
}*/


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());
int summa(int m, int n)
{
if (m==n)
return n;
else return m + summa(m + 1, n);
}
Console.Write($"Сумма натуральных элементов в промежутке от M до N равно {summa(m,n)}");*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

/*Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
int akkerman(int m, int n)
{
if (m == 0) return n+1;
else if (n == 0  && m > 0) 
return akkerman(m - 1, 1);
else return akkerman(m-1, akkerman(m, n - 1));
};
akkermanFun(m,n);
void akkermanFun(int m,int n){
    Console.WriteLine(akkerman (m,n));
}*/