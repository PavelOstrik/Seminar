/*
Задача 47. Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

void FillArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((new Random().NextDouble() * 2 - 1) * 10, 1);
            // * 2 -1 получаем отрицательный диапазон, умножаем на 2 чтобы значения были
            // как отрицательные так и положительные, вычитаем единицу, чтобы были 
            // отрицательные значения
        }
    }
}
    void PrintArray(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            System.Console.WriteLine();
        }
    }
    

    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    double[,] result = new double[rows, columns];
    FillArray(result);
    PrintArray(result);


/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента
в двумерном массиве, и возвращает значение этого элемента или же указание,
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
/*
Console.WriteLine("Введите позицию элемента: ");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[3, 3];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(11);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

if (rows <= matrix.GetLength(0) && columns <= matrix.GetLength(1))
    {
        Console.WriteLine(matrix[rows, columns]);        
    }
    else
        Console.WriteLine(rows + ", " + columns + " числа на такой позиции в массиве нет");
// Не разобрался, почему при превышении размера строки терминал выдаёт ошибку, что
// мы вышли за размер диапазона, а при первышении столбца нет и код работает
*/

/*
Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
/*
int[,] matrix = new int[3, 4];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(11);
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

double sum = 0;

for (int j = 0; j < matrix.GetLength(1); j++)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, j];
    }
    Console.Write($"{Math.Round(sum / matrix.GetLength(0), 1)} ");
}
*/
/*
Вариант записи преподавателя:

int[] MeanElem(int[,] array)
{
    int col = array.GetLength(1);
   int[] result  = new int[col];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result[col] += array[i, j];
        }
    }
    return result;
}
*/


