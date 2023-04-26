


/*int[]array = {1,29,32,4,5,6,70,8,9};

int result = Max(
    Max (array[0], array[1], array[2]),
    Max (array[3], array[4] ,array[5]),
    Max (array[6] ,array[7] ,array[8])
);
Console.WriteLine(result);

int Max (int arg1,int arg2,int arg3){
    int result = arg1;
    if(arg2>result) result=arg2;
    if(arg3>result) result=arg3;
    return result;
}*/
// int a1 = 15;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 23;
// int c2 = 33;
// int a3 = 13;
// int b3 = 23;
// int c3 = 3133;


// int max1= Max(a1,b1,c1);
// int max2= Max(a2,b2,c2);
// int max3= Max(a3,b3,c3);
// int max = Max(max1,max2,max3);
// int max = Max(Max(a1,b1,c1),
// Max(a2,b2,c2),
// Max(a3,b3,c3));


// int max = a1;
// if(b1>max) max = b1;
// if(c1>max) max = c1;

// if(a2>max) max = a2;
// if(b2>max) max = b2;
// if(c2>max) max = c2;

// if(a3>max) max = a3;
// if(b3>max) max = b3;
// if(c3>max) max = c3;


//Console.WriteLine(max);

//Массивы

// тип данных [ ] имя = {значение 1,значение 2,.....}
// int array = {9,28,1,32,1990}

//int[] array = {0,0,0,0,0}
//int[] array = new int[5]
//int[] array = new int[]{0,0,0,0}
//int[] array = new int[5]{1,0,2,1,3}

// Имеется одномерный массив array
// из n элементов, требуется найти элемент , равный find

// Установит счетчик  index в позицию 0;
// Если array [index] = find ,алгоритм завершил работу успешно;
// Увеличить index на 1;
// Если index < n,то перейти к шагу 2юВпротивном случае алгоритм завершит работу безушпешно.
// int []arrey = {1,9,3,45,63,78,34,9};

// int n = arrey.Length;
// int find = 9;
// int index = 0;
// while (index<n){
//     if(arrey[index] == find){
//         Console.WriteLine(index);
//         break;
//     }
//     index++;
// }


void FillArray(int[]collection){
    int length = collection.Length;
    int index = 0;
    while(index<length){
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArrey(int[]col){
    int count = col.Length;
    int position =0;
    while(position<count){
        Console.WriteLine(col[position]);
        position++;
    }
}
int IndexOf(int[]collection,int find){
    int count = collection.Length;
    int index = 0;
    int position = 0;   //-1 будет показывать что элемент в массиве не найден

    while(index<count){
        if(collection[index] == find){
            position = index;
            break;
        }
        index++;
    }
    return position;
    
}

int []arrey = new int[10];

// void метод который не чего не возвращает 
//нельзя использовать return

FillArray(arrey);
PrintArrey(arrey);
Console.WriteLine();

int pos = IndexOf(arrey,4);
Console.WriteLine(pos);






