/*
Задача 54: Задайте двумерный массив. Напишите программу,
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
/*
void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(11);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1)-1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
Console.WriteLine("Массив с упорядоченными по убыванию строками: ");
SortArray(array);
PrintArray(array);
*/

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет
находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей
суммой элементов: 1 строка
*/
/*
void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(6);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);

int sumLineOne = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumLineOne += array[i, j];
    }
    break;
}

int sumLine = 0;
int minSumLine = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    if (sumLineOne > sumLine)
    {
        sumLineOne = sumLine;
        minSumLine = i;
    }
    sumLine = 0;
}

Console.WriteLine
($"Строка с наименьшой суммой элементов ({sumLineOne}): {minSumLine + 1} строка");
*/

/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить
произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
Операция умножения двух матриц выполнима только в том случае,
если число столбцов в первом сомножителе равно числу строк во втором;
в этом случае говорят, что матрицы согласованы.
*/

/*
void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(6);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[\t");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}

void MultiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] newMatrix)
{
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[k, j] * secondMatrix[i, k];
            }
            newMatrix[i, j] = sum;
        }
    }
}

Console.Write("Введите количество строк первой матрицы: ");
int firstRows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов первой матрицы и строк второй матрицы: ");
int firstColumnsSecondRows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов второй матрицы матрицы: ");
int secondColumns = Convert.ToInt32(Console.ReadLine());

int[,] firstMatrix = new int[firstRows, firstColumnsSecondRows];
FillArray(firstMatrix);
PrintArray(firstMatrix);
Console.WriteLine();

int[,] secondMatrix = new int[firstColumnsSecondRows, secondColumns];
FillArray(secondMatrix);
PrintArray(secondMatrix);
Console.WriteLine();

int[,] newMatrix = new int[firstRows, secondColumns];

MultiplicationMatrix(firstMatrix, secondMatrix, newMatrix);
PrintArray(newMatrix);
*/

/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/


Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк в ширину: ");
int rowsWidth = Convert.ToInt32(Console.ReadLine());

int[,,] matrix3D = new int[rows, columns, rowsWidth];
if (rows * columns * rowsWidth < 89)
{
    void FillArray(int[,,] matrix, int minValue, int maxValue)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(2); k++)
                {
                    matrix[i, j, k] = minValue;
                    minValue++;
                }

            }
        }
    }

    void PrintArray(int[,,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(2); k++)
                {
                    if (matrix[i, j, k] != 0)
                    {
                        int indexRow = i;
                        int indexColumn = j;
                        int indexRowWidth = k;
                        // Console.Write(matrix[i, j, k] +
                        //  "(" + indexRow + ", " + indexColumn + ", " + indexRowWidth + ")" ) + "\t");
                        Console.Write($"{matrix[i, j, k]}({indexRow}, {indexColumn}, {indexRowWidth})\t");
                    }
                    else break;
                }
                Console.WriteLine();
            }
        }
    }

    FillArray(matrix3D, 10, 99);
    PrintArray(matrix3D);
}
else
{
    Console.WriteLine("Вы вышли за диапазон возможных значений, уменьшите размер матрицы");
}


/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

// Пока не одолел