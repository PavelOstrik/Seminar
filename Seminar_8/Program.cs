/*
Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива.
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

void ReplaceArray(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = temp;    
    }
}

int[,] array = new int[3, 4];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
ReplaceArray(array);
PrintArray(array);
*/

/*
Задача 55: Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя.
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
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void ReplaceArray2D(int[,] matrix)
{
    if (matrix.GetLength(0) == matrix.GetLength(1))
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = i + 1; j < matrix.GetLength(1); j++)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = temp;
            }
        }
    }
    else Console.Write("В заданном двумерном массиве невозможно заменить строки на столбцы");
    Console.WriteLine();
}

System.Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
Console.WriteLine();
ReplaceArray2D(array);
PrintArray(array);
*/

/*
Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных
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
        Console.Write("[\t");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        Console.Write("]");
        Console.WriteLine();
        
    }
}

//Конвертируем двумерный массив в одномерный
void ConvertMatrixToArray(int[,] matrix, int[] array)
{
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }
}

//Еще один способ конвертации:
// for (int i = 0; i < arrayTwo.GetLength(0); i++)
// {
//     for (int j = 0; j < arrayTwo.GetLength(1); j++)
//     {
//         arrayOne[i * columns + j] = arrayTwo[i, j];
//         //Console.Write(arrayOne[i*columns + j] + ",\t");        
//     }
// }


void PrintArrayOne(int[] matrix)
{
    int count = matrix.Length;
    Console.Write("[ ");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{matrix[i]}, ");
    }
    Console.Write(" ]");
}

void PrintVocabulary(int[] matrix)
{
    int count = 1;
    int temp = matrix[0];
    for (int i = 1; i < matrix.Length; i++)
    {
        if (temp != matrix[i])
        {
            Console.WriteLine($"Элемент {temp} встречается {count} раз");
            count = 1;
            temp = matrix[i];
        }
        else count++;
    }
    Console.WriteLine($"Элемент {temp} встречается {count} раз");
}

System.Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] arrayTwo = new int[rows, columns];

FillArray(arrayTwo);
PrintArray(arrayTwo);
Console.WriteLine();

int[] arrayOne = new int[rows * columns];

ConvertMatrixToArray(arrayTwo, arrayOne);
PrintArrayOne(arrayOne);
Console.WriteLine();

Array.Sort(arrayOne);
PrintArrayOne(arrayOne);
Console.WriteLine();

System.Console.WriteLine();
PrintVocabulary(arrayOne);
*/

/*
Задача 59: Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
*/
/*
1 способ решения
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
        Console.Write("[\t");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}

static (int row, int col) FindMin(int[,] matrix)
// Кортеж
// Кортеж представляет набор значений, заключенных в круглые скобки:
// В дальнейшем мы можем обращаться к каждому из этих значений через поля с названиями:
// Item[порядковый_номер_поля_в_кортеже]
// var tuple = (5, 10);
// var tuple = (5, 10);
// Console.WriteLine(tuple.Item1); // 5
// Console.WriteLine(tuple.Item2); // 10
// tuple.Item1 += 26;
// Console.WriteLine(tuple.Item1); // 31
{
    int rowsCount = matrix.GetLength(0);
    int columnsCount = matrix.GetLength(1);

    int minValue = matrix[0, 0];
    int rowMin = 0;
    int columnMin = 0;

    for (int i = 0; i < rowsCount; i++)
    {
        for (int j = 0; j < columnsCount; j++)
        {
            if (minValue > matrix[i, j])
            {
                minValue = matrix[i, j];
                rowMin = i;
                columnMin = j;
            }
        }
    }
    Console.WriteLine($"Минимальный элемент {minValue} имеет адрес {rowMin}, {columnMin}");
    System.Console.WriteLine();
    return (rowMin, columnMin);
}

static int[,] RemoveMinCrossover(int[,] matrix)
{
    (int rowMin, int columnMin) = FindMin(matrix);

    int rowsCount = matrix.GetLength(0);
    int columnsCount = matrix.GetLength(1);
    int[,] result = new int[rowsCount - 1, columnsCount - 1];

    for (int row = 0; row < rowsCount; row++)
    {
        for (int col = 0; col < columnsCount; col++)
        {
            if (row == rowMin || col == columnMin)
                continue;
            int newRow = row < rowMin ? row : row - 1;
            int newCol = col < columnMin ? col : col - 1;
            result[newRow, newCol] = matrix[row, col];
        }
    }
    return result;
}


System.Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);

System.Console.WriteLine();

int[,] NewArray = RemoveMinCrossover(array);

PrintArray(NewArray);
*/

//Способ Михаила
// int.MaxValue - максимальное число, больше которого в integer не помещается,
// при поиске минимального значения задавать минимальный элемент нужно всегда так
// int minElement = int.MaxValue;
/*
int rows = 3;
int columns = 3;
int[,] matrix = new int[rows, columns];
int minElement = int.MaxValue;
int minElementRow = 0; // Строчка с минимальным элементом
int minElementColumn = 0;// Столбец с минимальным элементом
for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) = rows
{
for (int j = 0; j < columns; j++) // matrix.GetLength(1) = columns
{
matrix[i, j] = new Random().Next(11); // [0;10]
Console.Write(matrix[i, j] + "\t"); // Tab
if (minElement > matrix[i, j]) // 5 > 0 , min = 0
{
minElement = matrix[i, j];
minElementRow = i;
minElementColumn = j;
}
}
Console.WriteLine();
}
Console.WriteLine($"Min = {minElement}, row: {minElementRow}, column: {minElementColumn} ");
for (int i = 0; i < matrix.GetLength(0); i++)
{
if (minElementRow != i)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (minElementColumn != j)
{
Console.Write(matrix[i, j] + "\t");
}
}
Console.WriteLine();
}
}
*/
