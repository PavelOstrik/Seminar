// Задача 10: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// Нужно сделать через числа, без индексов строк.
// 456 -> 5
// 782 -> 8
// 918 -> 1

/*
System.Console.Write("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());

if(number >= 100 && number <=999)
{
    int result = number / 10 - (number / 100) * 10;
    System.Console.WriteLine($"Вторая цифра от числа {number} = {result}");
}
else System.Console.WriteLine("Вы ввели не трёхзначное число");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

/*
System.Console.Write("Введите число ");
string number = Console.ReadLine();

if(number.Length >= 3 )
{
    System.Console.WriteLine($"Третья цифра от числа {number} = {number[2]}");
}
else System.Console.WriteLine("Третьей цифры нет");
*/

// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.Write("Введите цифру, обозначающую день недели ");
int numberDay = Convert.ToInt32(Console.ReadLine());

if(numberDay >=6 && numberDay <= 7)
{
    System.Console.WriteLine("Да, этот день выходной");
}
else System.Console.WriteLine("Нет, это будний день");