/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные
числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/
/*
Console.WriteLine("Введите начальное и конечное значения: ");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

if (M > N) Console.WriteLine("Начальное значение должно быть меньше конечного");
if (M > N) return;

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    
    return (start + ", " + PrintNumbers(start + 1, end));
}
Console.WriteLine($"Числа от {M} до {N} => ' {PrintNumbers(M, N)} '");
*/

/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*
Console.WriteLine("Введите начальное и конечное значения: ");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

if (M > N) Console.WriteLine("Начальное значение должно быть меньше конечного");
if (M > N) return;

int SumElements(int start, int end)
{
    if (start == end) return start;

    return (start + SumElements(start + 1, end));
}

Console.Write($"Сумма натуральных элементов в промежутке от {M} до {N}: -> {SumElements(M, N)}");
*/

/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
*/
/*
Console.WriteLine("Введите два неотрицательных числа: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

if (n < 0 || m < 0) return;
if (n < 0 || m < 0) Console.WriteLine("Введите неотрицательные числа");

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}
Console.WriteLine($"Функция Аккермана для чисел {m} и {n} = {Akkerman(m, n)}");
*/

