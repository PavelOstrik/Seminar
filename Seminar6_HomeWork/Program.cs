/*
Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
/*
void FillArray(int[] array) //Метод заполнения массива с консоли
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("Сколько чисел вы хотите ввести: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] numberArray = new int[size];
Console.WriteLine("Введите числа: ");

FillArray(numberArray);

int count = 0;
for (int i = 0; i < size; i++)
{
    if (numberArray[i] > 0) { count++; }
}

Console.WriteLine($"{String.Join(", ", numberArray)} -> {count}");
*/

/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2
задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
/*
Console.WriteLine("Введите значение b1, k1, b2, k2 : ");
double b1 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine("Точка перечения двух прямых при заданных значениях: ");
Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");
*/

/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/
/*
Console.WriteLine("Введите десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Получите двоичное число: ");
int remains = 1;
string result = String.Empty;
while (number > 0)
{    
    remains = number % 2;
    number = number / 2;
    result = remains.ToString() + result;
}
System.Console.WriteLine(result);
*/
