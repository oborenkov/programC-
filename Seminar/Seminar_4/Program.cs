﻿//Напишите программу ,которая принемает на вход число (А) и выдает сумму чисел от 1 до А

// int GetSum(int num){
//     int sum = 0;
//     for(int current = 1 ;current <= num;current++ )
//         sum = sum + current;
//         return sum;
// }
// Console.WriteLine( "Input a nunber: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int res = GetSum(a);
// Console.WriteLine($"Sum of nambers from 1 to {a} is {res}");

 int[] CreateRandomArray(int size,int minValue,int maxVelue){
    int[] array = new int[size];
    for(int i= 0;i<size;i++ )
       array[i]=new Random().Next(minValue,maxVelue + 1);
       return array;
 }
 void ShowArray(int[]array){
    for(int i =0;i<array.Length;i++)
    Console.Write(array[i] + "  ");
    Console.WriteLine();
 }

 Console.WriteLine("Input a size for array: ");
 int size = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input a min possible value: ");
 int  min = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input a max possible value: ");
 int  max = Convert.ToInt32(Console.ReadLine());

 int[] newArray = CreateRandomArray(size,min,max);
 ShowArray(newArray);







