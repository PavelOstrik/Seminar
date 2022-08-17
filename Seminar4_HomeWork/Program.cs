/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
/*
System.Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA < 0) numberA = -numberA;

System.Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberB < 0) numberB = -numberB;

int result = 1;

for (int i = 1; i <= numberB; i++)
{
    result *= numberA;
}
System.Console.WriteLine($"Результат вычислений числа {numberA} в степени {numberB}: {result}");
*/

/*
Задача 27: Напишите программу, которая принимает на вход число
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
/*
System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = 0;
int sum = 0;

while (number > 0)
{
    result = number % 10;
    sum += result;
    number = number / 10;
}
System.Console.WriteLine($"Сумма цифр числа равна: {sum}");
*/
/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

void FillArray(int[] collection) // метод для заполнения нашего массива
{
 int Length = collection.Length; // получаем длину нашего массива
    int index = 0;
    while (index < Length)
    {
        collection[index] = Convert.ToInt32(Console.ReadLine());        
        index++; 
    }
}
int[] array = new int[8];
System.Console.WriteLine("Введите 8 чисел: ");
FillArray(array);
Console.WriteLine($"Результат: [{String.Join(", " ,array )}]");
