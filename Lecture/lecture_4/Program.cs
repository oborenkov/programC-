// string[,]table = new string[2,5];
// String.Empty
// table[0,0],table[0,1],table[0,2],table[0,3]
// table[1,0][1,1][1,2]
// int[,]matrix= new int[5,8];
// table[1,2]= "слово";
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//        Console.Write($"{table[rows,columns]}-"); 
//     }
//     Console.WriteLine();
// }

// void PrintArrey(int[,]matr){

// for (int i = 0; i < matr.GetLength(0); i++)
// {
//     for (int j = 0; j < matr.GetLength(1); j++)
//     {
//        Console.Write($"{matr[i,j]}"); 
//     }
//     Console.WriteLine();
// }
// }
// void FillArrey(int[,]matr){
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j]= new Random().Next(1,10);
//         }
        
//     }
// }
// int[,]matrix= new int[5,8];
// PrintArrey(matrix);
// FillArrey(matrix);
// Console.WriteLine();
// PrintArrey(matrix);

//   int[,]pic = new int[,]
// {
//     {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
//     {0,0,0,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0},
//     {0,0,0,0,0,0,0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0},
//     {0,0,0,0,0,0,0,0,0,0,1,1,0,0,1,0,0,0,0,0,0,0,0,0,0},
//     {0,0,0,0,0,0,0,0,1,1,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
//     {0,0,0,0,0,0,1,1,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0},
//     {0,0,0,1,1,1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0},
//     {0,0,0,1,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0},
//     {0,0,0,1,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0},
//     {0,0,0,1,0,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,0,0,0,0},
//     {0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
//     {0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
//     {0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0},
//     {0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
//     {0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0},
//     {0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0},
//     {0,0,0,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0},
//     {0,0,0,0,0,0,0,0,1,1,1,1,0,0,0,0,0,0,0,1,0,0,0,0,0},
//     {0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1,0,0,0,0,0,0},
//     {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
//     {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
//     {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
//      {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},


// };


// void PrintImage(int[,] img){
//     for (int i = 0; i < img.GetLength(0); i++)
//     {
//         for (int j = 0; j < img.GetLength(1); j++)
//         {
//           if(img[i,j]==0) Console.Write($" ");
//           else Console.Write($"+");
//         }
//     }
// };
// PrintImage(pic);
// void FilldImage(int row , int col){
//     if(pic[row,col]== 0){
//         pic[row,col]=1;
//         FilldImage(row -1,col);
//           FilldImage(row,col -1);
//             FilldImage(row +1,col);
//               FilldImage(row ,col +1);
//     }

// };
// PrintImage(pic);
// FilldImage(13,13);
// PrintImage(pic);

//1!=1;0!=1
// double Factorial(int n){
//     if(n==1) return 1;
//       else return n * Factorial(n - 1); 
// }
// for (int i = 1; i < 40; i++)
// {
//  Console.WriteLine($"{i}!= {Factorial(i)}");

// }
//  //Console.WriteLine(Factorial(i));

//фибоначи

// f(1)=1
// f(2)=1
// f(n)=f(n - 1) + f(n-2)
// double Fibonacci(int n){
//   if (n == 1|| n==2) return 1;
//   else return Fibonacci(n-1) + Fibonacci(n-2);
  
// }
// for (int i = 1; i < 40; i++)
// {
//   Console.WriteLine(Fibonacci(i));
// }
