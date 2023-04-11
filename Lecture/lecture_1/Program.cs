//Console.WriteLine("Hello, World!");

/*
dotnet new console создание проекта
dotnet run запуск программы
Console мы обращаемся к системному терминалу
*/

// Console.Write("Ведите ваше имя ");
// string username = Console.ReadLine();
// Console.Write("Привет, ");
// Console.Write(username);
/* Write вывод в одну строку
   WriteLine в конце перейти на новую строку
   ReadLine считать строку из терминала
*/

/*int numberA = 3;
int numberB = 5;
int result = numberA + numberB;
//Console.WriteLine(numberA + numberB); 
Console.WriteLine(result);*/ 

// int numberA = 10;
// int numberB = 5;
// Console.WriteLine(numberA/numberB);

// double numberA = 12;
// double numberB = 5;
// Console.WriteLine(numberA / numberB);

/* 
   double- Рациональные числа
   int- Целые числа. Положительные и отрицательные числа
   string- строка(от 0 до мого символов)
   bool- true "правда" foise "ложь"
   %-  нажождение остатока от деления
   гениратор случайных чисел(случайности)
   new Random().Next(min,max)
   даст случайное целое число от min до max-1 [min,max-1]или[min,max]
*/

//  int numberA = new Random().Next(1,10);
//  Console.WriteLine(numberA);
//  int numberB = new Random().Next(1,10);;
//  Console.WriteLine(numberB);
//  int result = numberA + numberB;
//  Console.WriteLine(result);



// Console.Write("Ведите ваше имя пользователя ");
// string username = Console.ReadLine();
// if(username.ToLower() == "маша"){
//     Console.Write("Ура ,это же Маша!");
// }
// else{
//     Console.Write("Привет, ");
//     Console.WriteLine(username);
// }



// int a = 1;
// int b = 2;
// int c = 6;
// int d = 8;
// int e = 4;
// int max = a;
// if(a > max) max = a;
// if(b > max) max = b;
// if(c > max) max = c;
// if(d > max) max = d;
// if(e > max) max = e;
// Console.Write("max = ");
// Console.WriteLine(max);


Console.Clear();
/* Console.SetCursorPosition(10,4);
Console.WriteLine("+");*/

int xa = 40,ya = 1,
    xb = 1,yb = 30,
    xc = 80, yc = 30;
    Console.SetCursorPosition(xa, ya);
    Console.WriteLine("+"); 
    Console.SetCursorPosition(xb, yb);
    Console.WriteLine("+"); 
    Console.SetCursorPosition(xc, yc);
    Console.WriteLine("+"); 

    int x = xa, y = xb;
    int count = 0;
    while(count < 10000){
        int what = new Random().Next(0,  3);
        if(what == 0)
        {
            x = (x + xa) / 2;
            y = (y + ya) / 2;
        }
        if(what == 1)
        {
            x = (x + xb) / 2;
            y = (y + yb) / 2;
        }
        if(what == 2)
        {
            x = (x + xc) / 2;
            y = (y + yc) / 2;
        }
        Console.SetCursorPosition(x, y);
        Console.WriteLine("+");
        count++;
        
        

    }








