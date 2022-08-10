// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8
// из числа 78 получить 7 и 8 и вывести самое большое число

// int number = new Random().Next(10,100); // [10,100) это как [10,99]
// //System.Console.WriteLine("Рандомное число " + number); //Конкатенация - процесс сложения
// // строк
// System.Console.WriteLine($"Рандомное число: {number}");
//  //Интерполяция Console.WriteLine($"Текст: {пеерменная}")
// //Console.WriteLine($"Максимальная цифра в числе {number} - это {maximum}"); // Интерполяция
// //Console.WriteLine("Максимальная цифра в числе" + number + " - это " + maximum); // Конкатенация  
// int firstDigit = number / 10; // "/" деление без остатка
// int secondDigit = number % 10; // "%" остаток от деления на 10

// int maximum = firstDigit;      // пусть maximum - певрое число
// if (secondDigit > maximum) maximum = secondDigit;

// System.Console.WriteLine(maximum);



// Результаты вывода
// PS C:\Users\postr\OneDrive\Рабочий стол\Seminar\Seminar_2> dotnet run
// 48
// 8

//System.Console.WriteLine("Рандомное число " +number); Конкатенация - процесс сложения строк


// Задача 11: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую
// цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


int number = new Random().Next(100,1000); // [100,1000) это как [100,999]
System.Console.WriteLine($"Рандомное число: {number}");
 //456, как получить 4 (456/100), как получить 6 (456%10)
int firstDigit = number / 100; // "/" деление без остатка
int thirdDigit = number % 10; // "%" остаток от деления на 10

System.Console.WriteLine(firstDigit + "" + thirdDigit);

//2ой вариант 
//как получить число 46: 4 десятка(4*10), 6 единиц (6*1)
int number = new Random().Next(100,1000); //[100;999]
int result = (number / 100) * 10 + number % 10;
Console.WriteLine($"Первая и третья цифра числа  от числа {number} = {result}");

//3 вариант через индексы
string number = Console.ReadLine();
Console.WriteLine($"Результат: {number[0]}{number[2]} ");



// Задача 12: Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1,
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber % secondNumber == 0) Console.WriteLine("Кратные");
else Console.WriteLine($"Не кратно, остаток: {firstNumber % secondNumber}");




// Задача 14: Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

int number = Convert.ToInt32(Console.ReadLine());
// "&&" - Shift + 7 на Англ.раскладке
// апельсины и яблоки - покупаем и то, и то обязательно
// 1 и 1 - True(1); 1 и 0 - False(0)

if (number % 7 == 0 && number % 23 == 0) Console.WriteLine("Кратно");
else Console.WriteLine("Не кратно");

//Задача: Число должно делится на 3 или на 5
// "Или" - "||"
int number = Convert.ToInt32(Console.ReadLine());

if (number % 3 == 0 || number % 5 == 0) Console.WriteLine("Число кратно 3 или 5");
else Console.WriteLine("Число НЕ кратно 3 или 5");

Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.

int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

//int min = Math.Min(num1, num2);
int min = num1;
int max = num2;

if(num2 < num1) 
{
    min = num2;
    max = num1;
}
int sqr = min * max;

if(sqr == max)
{
    System.Console.WriteLine("Да");    
}
else System.Console.WriteLine("Нет");
