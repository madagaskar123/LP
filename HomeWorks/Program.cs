﻿
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

/*

Console.WriteLine ($" Input First number ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Input Second number");

int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
 {
 
  Console.WriteLine($"max number is {num1} and min number is {num2}");
 }

  else if (num1 < num2 )
  {
    Console.WriteLine($"max number is {num2} and min number is {num1}");

}
else 
{
Console.WriteLine($"{num1} is equals {num2} ");

}

*/



//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 2

/*


Console.WriteLine ($" Input First number ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Input Second number");

int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Input Third number");

int num3 =Convert.ToInt32(Console.ReadLine());



if (num1 > num2 )
 {
   if (num1 > num3)
    {
     Console.WriteLine($"max number is {num1}");

    }

     else  Console.WriteLine($"max number is {num3}");
 }

  else if (num2 > num1 )
  {

    if (num2 > num3)


     Console.WriteLine($"max number is {num2}");

     else Console.WriteLine($"max number is {num3}");


}

*/



//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число 
//чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

/*

Console.WriteLine ($" Input number ");

int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0 )
{
Console.WriteLine($"{num}  четное ");
}
else Console.WriteLine($"{num} нечетное");

*/ 


//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Input Number");

int num = Convert.ToInt32(Console.ReadLine());

int current = num / num + 1;

while (current <= num)

{
 Console.Write(current + " ");
 current += 2;
}



















