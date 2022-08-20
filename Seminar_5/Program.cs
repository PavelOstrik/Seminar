//char - символьный тип данный, обозначает ровно один символ, занимает памяти 2 бита,
// в отличие от string, которая обозначает множество и занимает 4 бита
 
// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.
/*
int[] array = new int[12]; // array = [0,0,0...,0]

int resultNegative = 0; // sumNegative (-)
int resultPositive = 0; // sumPositive (+)

for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(-9,10); // [-9;10)
// отрицательное число: array[i] < 0 , то число отрицательное
if (array[i] < 0) resultNegative += array[i]; // resultNegative = resultNegative + array[i]
else resultPositive += array[i]; // resultPositive = resultPositive + array[i]
}

Console.WriteLine($"[ {String.Join(" ,", array)} ]");
Console.WriteLine($"sumNegative: {resultNegative}, sumPositive: {resultPositive}");
*/
/*
Задача 32: Напишите программу замена элементов массива:
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/
/*
int[] array = new int[6];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9,10);    
}
System.Console.WriteLine($"[ {String.Join(", ", array)} ]");

for (int i = 0; i < array.Length; i++)
{
    array[i] = -array[i]; // array[i] *= (-1) еще 1 вариант записи   
    //Console.Write(array[i] + " ,"); // еще один способ вывода массива
}
System.Console.Write($"[ {String.Join(", ", array)} ]");
*/
/*
Задача 33: Задайте массив. Напишите программу, которая определяет,
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/
/*
int[] array = {6, 7, 19, 345, 3};
System.Console.Write("Введите искомое число: ");
int findNumber = Convert.ToInt32(Console.ReadLine());
if (findNumber < 0) findNumber = -findNumber;

System.Console.WriteLine($"[ {String.Join(", ",array)} ]");
bool found = false;//логический оператор, bool = false/true, если found = false , то
//элемент не найден, если found = true, то элмент нашли
for (int i = 0; i < array.Length; i++)
{    
    if (array[i] == findNumber)
    {
    found = true;        
    break; // после нахождения нужного числа цикл ломается, и не проверяет еще кучу значений
    }                
}
if (found) Console.WriteLine("Данное число присутствует в массиве");
// found == true -> if (found)
else Console.WriteLine("Данное число НЕ присутствует в массиве");

2-ой вариант решения, через строку
int[] array = { -2, -1, 0, 1, 2 };
int findNumber = 2;
string flagResult = "не найден";
// flagResult = false - element not found
// flagResult = true - element found
for (int i = 0; i < array.Length; i++)
{
if (findNumber == array[i])
{
flagResult = "найден";
break; // ломает цикл - цикл останавливается
}
}
Console.WriteLine($"Элемент: {flagResult}");
*/

/*
Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/
/*
int[] array = new int[123];
int size = array.Length // для оптимизации цикла лучше длину массива выносить в отдельную пере
//менную, так как в противном случае цикл будет вычислять длину массива в каждой итерации,
// size же уже является константой.
int count = 0;
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(1000);
    if (array[i] >= 10 && array[i] < 99 )
    {
        count++;
    }
}
System.Console.WriteLine($"[ {String.Join(" ,", array)} ]");
Console.WriteLine("Количество элементов массива, значения которых лежат в отрезке [10,99] = "
+ count);
//Решение через цикл while, ну или альтернативная запись
int start = 0; // int i = 0
while (start < size)
{
if (array[start] >= 10 && array[start] <= 99)
{
count++;
}
start++;
}
Console.WriteLine($"Количество элементов в диапазоне от 10 до 99 = {count}");
*/

//for (int i = 1; i < size; i += 2)  проверка на нечетность
// %2 == 0 проверка на четность