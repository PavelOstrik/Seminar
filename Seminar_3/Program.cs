// 17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
Console.Write("Введите координату по оси Х: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Введите координату по оси Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0) Console.WriteLine("I четверть");
if (x < 0 && y > 0) Console.WriteLine("II четверть");
if (x < 0 && y < 0) Console.WriteLine("III четверть");
if (x > 0 && y < 0) Console.WriteLine("IV четверть");
*/
/*
Задача 18: Напишите программу, которая по заданному номеру четверти,
показывает диапазон возможных координат точек в этой четверти (x и y).
*/
/* 
Console.WriteLine("Введите номер черверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());

if (quarter < 1 || quarter > 4) { Console.WriteLine("Error 404,quarter NOT FOUND"); }

if (quarter == 1) Console.WriteLine("x > 0 и y > 0");
if (quarter == 2) Console.WriteLine("x < 0 и y > 0");
if (quarter == 3) Console.WriteLine("x < 0 и y < 0");
if (quarter == 4) Console.WriteLine("x > 0 и y < 0"); 
*/
/*
Задача 21: Напишите программу, которая принимает на вход координаты двух
точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/
/*
Console.WriteLine("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

//int x = (x2 - x1) * (x2 - x1);
//int y = (y2 - y1) * (y2 - y1);
//AB = √(xb - xa)2 + (yb - ya)2

//Math.Sqrt - извлечь корень
//Math.Pow(x,2) - возведение в квадрат, где x переменная, а 2 степень в которую возводим
double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

//В данном варианте вывода кол-во знаков после запятой будет полным 
Console.WriteLine($"Расстояние между точками: {result}); 

//Здесь мы обрезаем кол-во знаков после запятой
Console.WriteLine($"Расстояние между точакми: {Math.Round(result,3)}");
// Math.Round(число, количество знаков после запятой)
// Math.Round(result,3) - округляет переменную result до 3 знаков после запятой
// в случае 5,09 -> напишет 5,1 (при условии (resalt,2))

// Еще 1 способ обрезания знаков в числе после запятой
Console.WriteLine($"Результат: {result:f3}");
// {переменная:fкол-во_знаков) -> {result:f3} - result "обрезается" до 3 знаков после запятой
//в случае 5,09 -> напишет 5,10 (при условии (resalt:f2))
/*
Задача 22: Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
[start;N]
*/
int n = Convert.ToInt32(Console.ReadLine());
/*
int start = 1;
while (start <= n)
{
Console.WriteLine($"Квадрат от числа {start} = {Math.Pow(start,2)} ");
//Console.Write(Math.Pow(i, 2) + "\t");  еще 1 вариант вывода результата в одну строку
//"\t" - литералы, все элементы разделены 1tab
//"\n" - перенос на новую строчку
//Console.WriteLine("Текст") тоже самое что Console.Write("Литерал" + "\n")
//https://metanit.com/sharp/tutorial/2.26.php прочитать дополнительно про литералы
start++;
}
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
*/
//еще 1 вариант записи цикла, более локаничный и удобный (while = for)
// ( начало, условие для цикла, увеличение счетчика (start))
for (int start = 1; start <= n; start++)
{
Console.WriteLine($"Квадрат от числа {start} = {Math.Pow(start,2)} ");
}
//Цикл for используем когда нам известно кол-во итераций(разовое выполнение цикла)
// while - когда известно условие, но не знаем кол-во итераций
