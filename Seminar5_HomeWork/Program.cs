/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
/*
int[] array = new int[10];
int size = array.Length;
int count = 0;
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100,1000); // [100;999]
    if (array[i] % 2 == 0)
    {
        count++;
    }
}
System.Console.WriteLine($"[{String.Join(", ", array) }]");
System.Console.WriteLine($"Количество четных чисел в массиве = {count}");
*/
/*
Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
/*
int[] array = new int[4];
int size = array.Length;
int sum = 0;
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100);    
}
for (int i = 1; i < size; i+=2)
    {
        sum += array[i];
    }    
System.Console.WriteLine($"[{String.Join(", ", array)}]");
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sum}");
*/
/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
/*
double[] array = new double[5];
Random rand = new Random();  // Создать экземпляр генератора случайных чисел
double size = array.Length;

for (int i = 0; i < size; i++)
{
    array[i] = Math.Round(rand.NextDouble()*100,2);    
}
System.Console.WriteLine($"[{String.Join(", ", array)}]");
*/


double [] array = new double[5];
double size = array.Length;
for (int i = 0; i < size; i++)
{
    array[i] = Math.Round(new Random().NextDouble() * 100,2);
}
System.Console.WriteLine($"[{String.Join(", ", array)}]");
// diff = max - min


double max = array[0];
double min = array[0];

for (int i = 0; i < size; i++)
{            
    if (array[i] > max) max = array[i];       
    if (array[i] < min) min = array[i];       
}
System.Console.WriteLine($"Макс = {max}, мин = {min}");
Console.WriteLine($"Разница между макс и мин элементов массива = {Math.Round((max - min),2)}");

