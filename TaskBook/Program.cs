/*
Даны два числа, которые вводятся в консоль построчно.
Вывести в консоль их среднее арифметическое.
Пример использования:
Выходные данные 1: Введите построчно два числа
Входные данные  1: (1) (3)
Выходные данные 1: Среднее арифметическое введенных чисел = 2
*/
/*
System.Console.WriteLine("Ввеждите два числа: ");
double number1 = Convert.ToDouble(Console.ReadLine());
double number2 = Convert.ToDouble(Console.ReadLine());

double result = (number1 + number2) / 2;
System.Console.WriteLine("Среднее арифметическое введенных чисел = " + result);
*/
/*
Дано положительное действительное число x.
Выведите его дробную часть не используя приведения и методы класса Math.
Пример использования:
Выходные данные 1: Введите вещественное число
Входные данные  1: 7.938
Выходные данные 1: Дробная часть числа = 0.938
*/
/*
System.Console.Write("Введите вещественное число: ");
double num = double.Parse(Console.ReadLine());
Console.WriteLine("Дробная часть числа = " + Math.Round(num % 1,3));
*/
/*
Дано положительное действительное число x.
Выведите его первую цифру после десятичной точки.
Пример использования:
Выходные данные: Введите действительное число с дробью
Входные данные : 15.89
Выходные данные: первая цифра в дроби - 8
*/
/*
Console.Write("Введите положительное вещественное число: ");
double num = Convert.ToDouble(Console.ReadLine());
double result = num * 10 % 10;
Console.WriteLine("Первая цифра в дроби = " + (int)result);
*/
/*
Home_156. Дана двумерный массив n*m заполненный значениями с клавиатуры.
Найти первое минимальное и последнее максимальное значения, и вывести их индексы элементов.
*/
/*
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(11);
        Console.Write(array[i, j] + "\t");
    }
    System.Console.WriteLine();
}

int min, max;
min = max = array[0,0];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i,j] < min)
        {
            min = array[i, j];
            rows = i;
            columns = j;                                    
            break;
        }                
    }    
}
Console.Write("Индексы минимального элемента равны: " + rows + ", " + columns);
System.Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] > max)
        {
            max = array[i, j];
            rows = i;
            columns = j;
        }
    }
}

Console.Write("Индексы максимального элемента равны: " + rows + ", " + columns);
*/

/*
На вход построчно подаются два целых числа a и b, проверить делится ли a на b нацело.
Выведите «Первое число делится на второе число без остатка» если a делится на b нацело,
иначе вывести «Первое число делится на второе число с остатком».
*/
/*
Console.WriteLine("Веедите два целых числа: ");
Console.WriteLine(Convert.ToInt32(Console.ReadLine()) 
% Convert.ToInt32(Console.ReadLine()) == 0 ? 
            "Первое число делится на второе число без остатка" :
            "Первое число делится на второе число с остатком"); 
 */

/*
Дано целое число n. Выведите следующее за ним четное число.
*/
/*
Console.WriteLine("Введите целое число: ");
Console.WriteLine("Следующее четное число: " + 
(Convert.ToInt32(Console.ReadLine()) / 2 * 2 + 2 ));
*/