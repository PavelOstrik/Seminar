/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
/*
System.Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();

if (number.Length == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        System.Console.WriteLine($"Число {number} является палиндромом");
    }
    else System.Console.WriteLine($"Число {number} НЕ является палиндромом");
}
else System.Console.WriteLine($"Вы ввели НЕ пятизначное число");
*/

/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
/*
System.Console.WriteLine("Введите координаты точки A: ");
System.Console.Write("x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты точки B: ");
System.Console.Write("x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

//D=sqrt((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2)

double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)
+ Math.Pow((z2 - z1), 2));
System.Console.WriteLine($"Расстояние между точками A и B: {Math.Round(result, 2)}");
*/

/*
Задача 23
Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
/*
System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int start = 1; start <= n; start++)
{
    System.Console.Write(Math.Pow(start, 3) + "\t");
}
*/