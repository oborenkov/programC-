// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

/* int a = -9;//5,2
int b = -3;//7,10
int max = 0;
int min = 0;
if(a>b){
    max=a;
}
else{
    max=b;
}
if(a>b){
    min=b;
}
else{
   min=a;
}
  Console.WriteLine("max number "  +max);
  Console.WriteLine("min number "  +min); 
  */


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

/*
int a=2;//44,22
int b=3;//5,3
int c=7;//78,9
int max =0;
if(a>b){
    max=a;
}
else{
    max=b;
}
if(b>c){
    max=b;
}
else{
    max=c;
}
if(c>a){
    max=c;
}
else{
    max=a;
}
Console.WriteLine("max number "  +max);
*/





// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет
/*
Console.Write("Enter the number: ");
int num1 =Convert.ToInt32(Console.ReadLine());
 int even = num1 % 2;
 if(even == 0){
  Console.Write("The number is even!!");
 }
 else{
  Console.Write("The number is odd!!");
 }
 */

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

/*
Console.Write("Enter the number: ");
int num1 =Convert.ToInt32(Console.ReadLine());
int even = 2;
if(num1>1){
  while(even<=num1){
    Console.Write( " " + even );
    even = even +2;
  }
}
*/




