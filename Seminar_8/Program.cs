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
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void PrintVocabulary(int[] matrix)
{
    int count = 1;
    int temp = matrix[0];
    for (int i = 1; i < matrix.Length; i++)
    {
        if (temp != matrix[i])
        {
            System.Console.WriteLine($"Элемент {temp} встречается {count} раз");
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

int[] arrayOne = new int[rows * columns];

for (int i = 0; i < arrayTwo.GetLength(0); i++)
{
    for (int j = 0; j < arrayTwo.GetLength(1); j++)
    {
        arrayOne[i * columns + j] = arrayTwo[i, j];
        //Console.Write(arrayOne[i*columns + j] + ",\t");        
    }
}

Array.Sort(arrayOne);

for (int i = 0; i < arrayTwo.GetLength(0); i++)
{
    for (int j = 0; j < arrayTwo.GetLength(1); j++)
    {
        Console.Write(arrayOne[i * columns + j] + ",\t");
    }
}

System.Console.WriteLine();
PrintVocabulary(arrayOne);
*/

/*
Задача 59: Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
*/

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

void DeleteMinNumberArray(int[,] array)
{
int min = array[0, 0];
int row = 0;
int column = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (min > array[i, j])
        {
            min = array[i, j];
            row = i;
            column = j;
        }
    }
}
Console.WriteLine($"Минимальный элемент {min} имеет адрес {row}, {column}");
System.Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i == row || j == column)
        {
            
        }             
        else
        Console.Write(array[i,j] + "\t");
    }    
    Console.WriteLine();
}
}


System.Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
DeleteMinNumberArray(array);

