//Вы продлили срок сдачи задания до 24 апр., 10:00 +03:00 UTC


// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// int DegreeNun(int num1,int num2){
//     int result=1;
//     for(int i = 1;i<= num2;i++)
//        result= result*num1;
//         return result;
// }
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите степень числа: ");
// int b = Convert.ToInt32(Console.ReadLine());

// int Degree = DegreeNun(a,b);
// Console.WriteLine($" {a} в степени {b} = {Degree}" );


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Console.Write("Введите число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

//   int SumNum(int number){
    
//     int counter = Convert.ToString(number).Length;
//     int a = 0;
//     int result = 0;

//     for (int i = 0; i < counter; i++){
//       a = number - number % 10;
//       result = result + (number - a);
//       number = number / 10;
//     }
//    return result;
//   }

// int sumNum = SumNum(num1);
// Console.WriteLine("Сумма цифр в числе: " + sumNum);



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// Console.WriteLine("Введите  число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string Num = Convert.ToString(num);
// int[] array= new int [Num.Length];
// int i;
// for(i=0;i<Num.Length;i++)
// {
// array[i]=Convert.ToInt32(Num[i].ToString());
// Console.WriteLine(array[i] + "");
// }





