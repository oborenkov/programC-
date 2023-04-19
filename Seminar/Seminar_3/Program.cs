// Math.Round(a,b) определение точности где -a число ,а -b точность(используется непосредственно перед выводом информации)
// Math.Pow(a,b)= a в степени b(double)
// Math.Sqrt(a)=корен a(double)
// метод  void

//Task 1. Напишите программу ,которая по заданному номеру четверти показывает диапазон возможных точек в этой четверти(x, y).


void ShowRange(int quadrant){
    if(quadrant == 1) 
      Console.WriteLine("x > 0 and y > 0");
      else if(quadrant == 2)
      Console.WriteLine("x < 0 and y > 0");
      else if(quadrant == 3)
      Console.WriteLine("x < 0 and y < 0");
      else if(quadrant == 4)
      Console.WriteLine("x > 0 and y < 0");
      else Console.WriteLine("Quadrant donsnt exist");
      
}
Console.Write("Input a number of quadrant: ");
int quadNum = Convert.ToInt32(Console.ReadLine());
ShowRange(quadNum);


// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.


//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.



