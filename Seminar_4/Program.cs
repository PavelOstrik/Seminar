//1. Методы, которые возвращают какое-то значение (не Void)
//2. Void
// тип метода Имя (параметры)
/*
1. Методы, которые возвращают какое-то значение (не Void)
int Calculate (int a, int b)
{
    int result = 0;
    result = a + b;
    return result;
}
System.Console.WriteLine(Calculate(5,2));

2. Void - метод, который ничего не возвращает, используется в основном для сохранения.
Пример void метода - печать массива.
void voidCalculate (int a, int b)
{
    int result = 0;
    result = a + b;
    System.Console.WriteLine(result);
}
voidCalculate((5,2));
*/
/*
Задача 24: Напишите программу, которая принимает на вход число (А)
и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/
/*
int number = Convert.ToInt32(Console.ReadLine());
// PascalCase - первая буква с заглавной буквы и все последующие слова так же, в отличае
// от CamalCase, где первое слово с маленькой буквы
// type Name (params)
int GetSumNumbers(int num)
{
    int start = 1; // [1;A]
    int sum = 0; // Суммы еще нет - значение 0
    while (start <= num)
    {
        sum += start; // sum = sum + start
        // sum *= start => sum = sum * start
        start++; // start = start + 1
    }
    return sum;
}

Console.WriteLine($"Сумма чисел от 1 до {number} = {GetSumNumbers(number)}");
*/

/*
Задача 26: Напишите программу, которая принимает на вход число и выдаёт
количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
/*
int number = Convert.ToInt32(Console.ReadLine());

int GetCountNumbers(int num)
{
    int count = 0; // Количество чисел
    while (number > 0)
    {
        count++;
        number/=10; number = number / 10, мы делим без остатка пока number не равен нулю,
        //123/10=12 12/10= 1 1/10 = 0
    }
    return count;
}

Console.WriteLine($"Количество цифр в числе {number} = {GetCountNumbers(number)}");
*/

/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/
/*
int number = Convert.ToInt32(Console.ReadLine());
int GetMultiply(int num) // PascalCase 
{
    int start = 1; // [1;A]
    int result = 1; // Произведение
    while (start <= num)
    {
        result *= start;
        // result = result + start
        // result *= start => result = result * start
        start++; // start = start + 1
    }
    return result;
}
Console.WriteLine($"Произведение чисел от 1 до {number} = {GetMultiply(number)}");
*/


/*
Задача 30: Напишите программу, которая выводит массив из 8 элементов,
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

// https://serg40in.ru/reshaem-400-zadach-na-c/
// Задачник по c#