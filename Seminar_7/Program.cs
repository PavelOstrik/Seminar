/*
Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1
*/

/*
// Сам решил по материалам лекции
void FillArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(100); // [0;99]
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]} ");            
        }
        System.Console.WriteLine();
    }
}
System.Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] arrayDouble = new int[n, m];
PrintArray(arrayDouble);
FillArray(arrayDouble);
PrintArray(arrayDouble);
*/
/*
// Решение Михаила на семинаре
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

// Заполнение массива
// Матрица - табличка - двумерный массив
// m - строчки, n - столбцы
int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++) // по строчкам
    {
        // i, j, m, k
        for (int j = 0; j < matrix.GetLength(1); j++) // по столбцам
        {
            matrix[i, j] = new Random().Next(11); // [0;10]
        }
    }
    return matrix;
}
int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);

// Печать массива

void PrintArray(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t"); // "\t" - Tab
        }
        Console.WriteLine();
    }
}
*/

/*
Задача 48: Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/
/*
void GetArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

System.Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
GetArray(array);
PrintArray(array);
*/


/*
Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
и замените эти элементы на их квадраты.
*/
/*
// Моё решение
void GetArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(10);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] array = new int[3,4];
GetArray(array);
PrintArray(array);
System.Console.WriteLine();

void GetResult(int[,] matrix)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i,j] *= array[i,j] ;
            }
        }
    }
}
GetResult(array);
PrintArray(array);
*/
/*
// Решение Михаила
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];
for (int i = 0; i < matrix.GetLength(0); i++) // по строчкам
{
    // i, j, m, k
    for (int j = 0; j < matrix.GetLength(1); j++) // по столбцам
    {
        matrix[i, j] = new Random().Next(11); // [0;10]
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Result: ");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i % 2 == 0 && j % 2 == 0)
        {
            Console.Write(matrix[i, j] * matrix[i, j] + "\t");
        }
        else Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
*/


/*
Задача 51. Найти сумму элементов главной диагонали.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/
/*
// Моё решение
void GetArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(10);
        }
    }
}
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] array = new int[3, 4];
GetArray(array);
PrintArray(array);

int sum = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i == j) { sum += array[i, j]; }
    }
}
System.Console.WriteLine("Сумма элементов главной диагонали: " + sum);
*/
/*
//Решение Михаила без метода
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];
for (int i = 0; i < matrix.GetLength(0); i++) // по строчкам
{
    // i, j, m, k
    for (int j = 0; j < matrix.GetLength(1); j++) // по столбцам
    {
        matrix[i, j] = new Random().Next(11); // [0;10]
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

int sum = 0; // Элементы еще не суммировали
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i == j) sum += matrix[i, j]; // sum = sum + matrix[i,j]
    }
}

Console.WriteLine($"Сумма элементов главной диагонали: {sum} ");
/*

//Преобразование целого числа в двоичное в C#
//https://www.techiedelight.com/ru/convert-integer-to-binary-csharp/
