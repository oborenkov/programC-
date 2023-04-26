// Функции в программировании 
// ВозврощаемыйЕипДанных ИмяМетода([ТипДанных ИмяАргумента1,.....]){
//     Тело Метода
//     return ЗначениеСоответсвующееВозвращаемомуТипуДанных;
// }

//1
// void Method(){
//     Console.WriteLine("Aftor");
// }
// Method();

//2

// void Method1(string msg){
//     Console.WriteLine(msg);
// }
// Method1(msg:"текст сообщения");

// void Method21(string msg,int count){
//     int i =0;
//     while(i<count){
//         Console.WriteLine(msg);
//         i++;
//     }
	
// }
 //Method21("Текст сообщения",4);
// Method21(count: 4,msg:"новый текст");


 //3
// int Method3(){
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

//4
// string Method4(int count,string text){
//     int i = 0;
//     string result = String.Empty; //" "; пустая строка
//     while(i<count){
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string rez = Method4(4,"r");
// Console.WriteLine(rez);

//5

// string Method5(int count, string text){
//     string result =String.Empty;
//     for(int i =0;i<count;i++){
//         result=result + text;
//     }
//     return result;
// }
// string rez = Method5(4,"r");
// Console.WriteLine(rez);

//6

// for(int i=2;i<=10;i++){
//     for(int j =2;j<=10;j++){
//         Console.WriteLine($"{i}*{j}={i*j}");
//     }
//     Console.WriteLine();
// }


//=======  Работа стекстом 
// Дан текст. В тексте нужно все пробелы заменить на черточки
// маленькие буквы "к" заменить большими "К"
// а большие "С" заменить маленькими "с"


// string text = "- Я думаю, - сказал князь ,улыбаясь, - что,"
// + "ежели бы вас послали вместо нашего милого Винценгороде,"
// + "вы бы взяли приступом согласие прусского короля."
// + "Вы так кросноречивы.Выдадите мне чаю";

// string RapLace(string text, char oldValue, char newValue)
// {
// 	string result = String.Empty;
// 	int length = text.Length;
// 	for(int i=0;i<length;i++)
// 	{
// 		if(text[i] == oldValue) result = result + $"{newValue}";
// 		else result=result + $"{text[i]}";
// 	}
	
// 	return result;
// }
// string newText = RapLace(text,' ','|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = RapLace(text,'к','К');
// Console.WriteLine(newText);


int[]arr={1,5,4,3,2,6,7,1,1};
void PrintArray(int[]array)
{
	int count = array.Length;
	for (int i = 0; i < count; i++)
	{
		Console.Write($"{array[i]} ");
	}
	Console.WriteLine();
		
	}
	
	void SelectionSort(int[]array)
	{
		for (int i = 0; i < array.Length - 1; i++)
		{
			int minPosition = i;
			for (int j = i +1; j < array.Length; j++)
			{
				if (array[j] < array[minPosition]) minPosition =j; 
				
			}
			
			int temporary = array[i];
			array[i]= array[minPosition];
			array[minPosition]= temporary;
		}
	}
	
	PrintArray(arr);
	SelectionSort(arr);
	PrintArray(arr);
	
	// упорядочить от большегго к меньшему
	// if (array[j] > array[minPosition]) minPosition =j; 







