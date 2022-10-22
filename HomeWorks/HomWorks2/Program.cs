//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
//вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1


/*int CutNumber (int num)
{


    int result = num /10 % 10 ;
     return result ;

    
}
int RandomNumber = new Random().Next(100,1000);

int result = CutNumber(RandomNumber);
Console.WriteLine($"Second Digit Number of {RandomNumber} is {result}");
 
 
*/

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6

/*

Console.WriteLine("Введите число");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2)
{
  Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}


*/



//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

/*
Console.WriteLine(" введи цифру обозначающиую день недели от 1 до 7");
int dayNumber=Convert.ToInt32(Console.ReadLine());
void checkTheDayOfTheWeek(int num)
{   
    if (dayNumber >=6 )
    
    Console.WriteLine($"{num} выходной ? -> да ");

    else 
    Console.WriteLine($"{num} выходной ? ->  нет");
} 
checkTheDayOfTheWeek(dayNumber);

*/


 
