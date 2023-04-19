
// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

//  bool Palindrome(int number)
// {
//     int num1 = number / 10000;
//     int num2 =  number % 10;
//     int num3 = (number / 1000) % 10;
//     int num4 = (number / 10) % 10;

//     if(num1 == num2 && num3 == num4) return true;
//     else return false;
// }

// Console.WriteLine("Введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int examination = number / 10000;
// if(examination >= 1 && examination<= 9) 
// {
//     if(Palindrome(number) == true) 
//     Console.WriteLine("Число является палиндромом");
//     else 
//     Console.WriteLine("Число не является палиндромом");
// }
// else Console.WriteLine("Число не является пятизначным, повторите ввод.");



// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53









// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// void NumСubes(int num)
// {
//     for(int a = 1; a <= num; a = a + 1)
//     Console.WriteLine($"{a} - {Math.Pow(a, 3)}"); 
// }

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// NumСubes(num);