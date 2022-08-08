/*
Напишите программу, которая на вход принимает число
и выдаёт его квадрат (число умноженное на само себя).
Например:
4 -> 16
-3 -> 9
-7 -> 49
*/
// int number = Convert.ToInt32(Console.ReadLine());
// int square = number * number; // 1 вариант
// // double testResult = Math.Pow(number, 2); 2 вариант 
// Console.WriteLine("Результат: " + square);

// PS C:\Users\postr\OneDrive\Рабочий стол\Seminar\Seminar_1> dotnet run
// 5
// Результат: 25

// Задача 1. Напишите программу, которая на вход
// принимает два числа и проверяет, является ли
// первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

// Console.Write("Введите первое число ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// if (firstNumber == secondNumber * secondNumber)// "==" проверка на равенство
// {                                              // перед фигурной скобкой ; не ставится
//     System.Console.WriteLine(firstNumber + " является квадратом от "+ secondNumber);
// }
// else
// {
//     System.Console.WriteLine(firstNumber + " не является квадратом от "+ secondNumber);
// }

// Результаты вывода
// PS C:\Users\postr\OneDrive\Рабочий стол\Seminar\Seminar_1> dotnet run
// Введите первое число 25
// Введите второе число 5
// 25 является квадратом от 5
// PS C:\Users\postr\OneDrive\Рабочий стол\Seminar\Seminar_1> dotnet run
// Введите первое число 50
// Введите второе число 5
// 50 не является квадратом от 5

// Задача №2: Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

// int dayNumber = Convert.ToInt32(Console.ReadLine());
// if (dayNumber == 1)
// {
//     System.Console.WriteLine("Понедельник");
// }
// if (dayNumber == 2)
// {
//     System.Console.WriteLine("Вторник");
// }
// if (dayNumber == 3)
// {
//     System.Console.WriteLine("Среда");
// }
// if (dayNumber == 4)
// {
//     System.Console.WriteLine("Четверг");
// }
// if (dayNumber == 5)
// {
//     System.Console.WriteLine("Пятница");
// }
// if (dayNumber == 6)
// {
//     System.Console.WriteLine("Суббота");
// }
// if (dayNumber == 7)
// {
//     System.Console.WriteLine("Воскресенье");
// }
// else
// {
//     System.Console.WriteLine("Такого дня нет");
// }

// Результат вывода
// PS C:\Users\postr\OneDrive\Рабочий стол\Seminar\Seminar_1> dotnet run
// 1
// Понедельник

// Задача №3: Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые числа в
// промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

int number = Convert.ToInt32(Console.ReadLine()); // число N
//Мы должны проверить положительное ли число, и если нет, сделать его положительным
if (number < 0)
{
    number = number * (-1); // второй вариант записи number = -number
}
//теперь нужно указать левую границу -N = N * (-1)
int negativeNumber = number * (-1); // -N
//[-N;N]
while (negativeNumber <= number) // ввели 4, и идем от -4 пока не дойдём до 4
{
    System.Console.WriteLine(negativeNumber);
    negativeNumber++; // инкремент увеличиваем на 1, можно также написать как negativeNumber=negativeNumber + 1
    // negativeNumber--  negativeNumber=negativeNumber - 1  декримент
}

// Результат вывода:
// PS C:\Users\postr\OneDrive\Рабочий стол\Seminar\Seminar_1> dotnet run
// 5
// -5
// -4
// -3
// -2
// -1
// 0
// 1
// 2
// 3
// 4
// 5