
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

/*Console.WriteLine("Введите  натуральное трехзначное число и мы Вам покажем вторую цифру :");
int num = Convert.ToInt32(Console.ReadLine());

 if(num>100 && num<1000){
Console.WriteLine("Вы ввели  корректное число");
}
else
{
    Console.WriteLine("Вы ввели не корректное число повторите попытку " );
    return;
}
int SecondNum( int num)
{
     int second = num/10%10;
    return second;
}

Console.WriteLine("Ваша вторая цифра  " + SecondNum(num));
*/
 


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

    /*int ThirdDigit(int number)
        {
            int result = -1;
            if (number >= 100)
            {
                while (number > 999)
                {
                    number = number / 10;
                }
                result = number % 10;
            }
            return result; 
        }
        Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
 
if (ThirdDigit(number1) == -1)
Console.WriteLine("третьей цифры нет");
else
Console.WriteLine($"Ваша третия цифра {ThirdDigit(number1)}");
*/










// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


/*Console.Write("Введи цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
bool dayNumber= Convert.ToBoolean(day);
bool DayOff(bool dayNumber){
  if(day > 5 && day < 8){
    return true;
  }
  else{
    return false;
  }
}
Console.WriteLine(DayOff(dayNumber));
*/



