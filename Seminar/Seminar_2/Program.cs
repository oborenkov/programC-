// напишите программу ,которая выводит случайное трехзначное число и удаляет вторую цифру

/*int randNamber= new Random().Next(100,1000); // случайная генирация числа

int CutNumber(int num) {

    int hunders =num / 100;
    int units = num %  10;

    int result = hunders * 10 + units;
    return result;
}
 
 int newNumber= CutNumber(randNamber);
 
 Console.WriteLine($"New version of {randNamber} is {newNumber}");
 */



//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

/*
int MaxDiget(int num){
    int tens = num / 10;
    int units = num % 10;
    int max = 0;
    if(tens>units){
        tens = max;
    }
    else{
        max = units;
    }
    return max;
}
int randNamber= new Random().Next(10,100);
int newNumber = MaxDiget(randNamber);
Console.WriteLine($"Largest digit of a number {randNamber} is {newNumber}");
*/







//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.
/*
Console.WriteLine("Введите число и мы узнаем является ли оно кратным случайных двух чисел ");
 int num = Convert.ToInt32(Console.ReadLine());
 int a = new Random().Next(10,100);//Convert.ToInt32(Console.ReadLine()); можно запросить у пользователя
 int b = new Random().Next(10,100);//Convert.ToInt32(Console.ReadLine()); можно запросить у пользователя

 bool Multiple(int num,int a,int b){
    if(num % a == 0 && num % b == 0){
        return true;
    }
    else{
        return false;
    }
 }
 Console.WriteLine("Cлучайное число " + a);
 Console.WriteLine("Cлучайное число " + b);
 Console.WriteLine(Multiple(num,a,b));
 */


 //Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
 
 Console.WriteLine("Введите превое число :");
 int a = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите второе число и узнаем является ли оно квадратом первого :");
 int b = Convert.ToInt32(Console.ReadLine());
 bool Quadr(int a, int b){
    if(a == b * b || b == a * a ){
        return true;
    }
    else{
        return false;
    }
 }
Console.WriteLine(Quadr(a,b));






