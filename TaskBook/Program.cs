//Напишите программу для вывода своих фамилии, имени и отчества на каждой новой строке.
/*
System.Console.Write("Введите своё имя: ");
string name = Console.ReadLine();

System.Console.Write("Введите своё отчество: ");
string patronymic = Console.ReadLine();

System.Console.Write("Введите свою фамилию: ");
string surname = Console.ReadLine();
*/

// Вывести на экран пять строк из нулей, причем количество нулей в каждой строке
// равно номеру строки. Использовать только Console.Write().

//System.Console.Write("0\n00\n000\n0000\n00000");
// "\n" управляющий символ перевода курсора на новую строчку

//Console.Write(5 + " 11 1025");
//Console.Write(5 + " 11 1025");
//Console.Write("5 11" + 1025);
//Console.Write(5 + " " + 11 + " " + 1025);

// Home_1. Составить программу вывода на экран в одну строку трех любых чисел
//с двумя пробелами между ними.
// System.Console.WriteLine("Введите 3 числа: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// int number2 = Convert.ToInt32(Console.ReadLine());
// int number3 = Convert.ToInt32(Console.ReadLine());


// Home_2. Составить программу вывода на экран в одну строку четырех любых чисел
// с одним пробелом между ними.
//System.Console.Write(1 + " " + 2 + " " + 3 + " " + 4);

//Home_3. Вывести на одной строке числа 1, 13 и 49 с одним пробелом между ними.
//System.Console.WriteLine(1 + " " + 13 + " " + 49);

//Home_4.Вывести на одной строке числа 7, 15 и 100 с двумя пробелами между ними.
//System.Console.WriteLine(7 + "  " + 15 + "  " + 100);

//Home_5. Вывести на экран числа 50 и 10 одно под другим.
// System.Console.WriteLine(50);
// System.Console.WriteLine(10);

//Home_6. Вывести на экран числа 5, 10 и 21 одно под другим.
// System.Console.WriteLine(5);
// System.Console.WriteLine(10);
// System.Console.WriteLine(21);

//Home_7. Составить программу вывода на экран «столбиком» четырех любых чисел
// System.Console.WriteLine("Введите 4 числа: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// int number2 = Convert.ToInt32(Console.ReadLine());
// int number3 = Convert.ToInt32(Console.ReadLine());
// int number4 = Convert.ToInt32(Console.ReadLine());

// Home_8. Вывести на экран текущее название дня недели,
// название месяца и свое имя. Каждое слово должно быть в отдельной строке.
// System.Console.WriteLine("Среда");
// System.Console.WriteLine("Август");
// System.Console.WriteLine("Павел");

// Home_9. Вывести на экран прямоугольник, заполненный буквами А.
// Количество строк в прямоугольнике равно 5, количество столбцов равно 8.
// System.Console.WriteLine("AAAAAAAA\n"+
//                          "AAAAAAAA\n"+
//                          "AAAAAAAA\n"+
//                          "AAAAAAAA\n"+
//                          "AAAAAAAA");

//Home_10. Вывести на экран букву «W» из символов «*» (звездочка).
// System.Console.WriteLine("*       *\n"+
//                          " *  *  *\n"+
//                          "  *   *");

// Объявите переменную с именем myPerson строкового типа и запишите в неё свое имя
// на первой строке, а фамилию на второй строке.

//string myPerson = "Pavel\nOstrik";


//05. Ввод информации. Конвертация

//Задача: По данному целому числу, найдите его квадрат.
// Пример использования:
// Выходные данные 1: Введите целое число
// Входные данные  1: 5
// Выходные данные 1: Квадрат числа = 25
// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Квадрат числа {number} = {Math.Pow(number,2)}");

// Задача: Написать программу для обмена значений двух построчно введенных
// в консоль целых переменных, и вывода результата на одной строке.
// Пример использования:
// Выходные данные 1: Введите построчно два числа для перестановки
// Входные данные  1: (10) (20)
// Выходные данные 1: Значения после перестановки
// Выходные данные 1: 20 10
// System.Console.WriteLine("Введите построчно два числа дял перестановки:");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int temp = a;
// a = b;
// b = temp;
// System.Console.WriteLine($"Значение после перестановки: {a}  {b}");

//06. Операции с целыми числами

// int num1 = 18;
// int num2 = 8;
// Console.WriteLine("первое число =  " + num1 + ", второе число = " + num2);
// int result = num1 + num2;
// Console.WriteLine("Сложение: \t\t"+ num1 + "+" + num2 + "=" + result);            // 26 
// result = num1 * num2;
// Console.WriteLine("Умножение: \t\t" + num1 + "*" + num2 + "=" + result);         // 144
// result = num1 / num2;
// Console.WriteLine("Деление нацело: \t" + num1 + "/" + num2 + "=" + result);      // 2
// result = num1 % num2;
// Console.WriteLine("Деление с остатком: \t" + num1 + "%" + num2 + "=" + result);  // 2 

// Напишите программу, которая находит сумму и произведение трёх целых чисел,
// построчно введённых с клавиатуры в консоль.
// Пример использования:
// Выходные данные 1: Введите построчно три числа
// Входные данные  1: (1) (2) (3)
// Выходные данные 1: Сумма = 6; Произведение = 6
// System.Console.WriteLine("Введите три числа: ");
// int numberOne = Convert.ToInt32(Console.ReadLine());
// int numberSecond = Convert.ToInt32(Console.ReadLine());
// int numberThird = Convert.ToInt32(Console.ReadLine());
// int sum = numberOne + numberSecond + numberThird;
// int pow = numberOne * numberSecond * numberThird;
// System.Console.WriteLine("Сумма = " + sum  + ";" + " Произведение = " + pow);

// Написать программу нахождения результата для следующего задания:
// n школьников делят k яблок поровну, не делящийся остаток остается
// в корзинке. Данные вводятся построчно. Программа должна вывести сколько
// яблок достанется каждому школьнику.
// Пример использования:
// Выходные данные 1: Введите построчно два числа
// Входные данные  1: (3) (7)
// Выходные данные 1: 7 / 3 = 2

// System.Console.Write("Введите количество школьников: ");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите количество яблок: ");
// int k = Convert.ToInt32(Console.ReadLine());
// //System.Console.WriteLine($"{k / n} яблока достанется каждому школьнику");
// Console.WriteLine(k + " / " + n + " = " + (k / n));

// Написать программу нахождения результата для следующего задания:
// n школьников делят k яблок поровну,
// не делящийся остаток остается в корзинке.
// Данные вводятся построчно. Программа должна вывести сколько яблок останется в корзинке?
// Пример использования:
// Выходные данные 1: Введите построчно два числа
// Входные данные  1: (3) (7) 
// Выходные данные 1: Остаток 7 / 3 = 1

// System.Console.Write("Введите количество школьников: ");
// int students = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите количество яблок: ");
// int apple = Convert.ToInt32(Console.ReadLine());
// //System.Console.WriteLine($"{apple % students} яблока останется в корзине");
// Console.WriteLine(apple + " / " + students + " = " + (apple % students));

// Написать программу для нахождения результата из следующей задачи:
// пирожок в столовой стоит a рублей и b копеек. Вывести в консоль сколько рублей
// и копеек нужно заплатить за n пирожков. Данные вводятся с консоли построчно: a, b, n.
// Пример использования:
// Выходные данные 1: Введите целое число, обозначающие количество рублей
// Входные данные  1: 5
// Выходные данные 1: Введите целое число, обозначающие количество копеек
// Входные данные  1: 50
// Выходные данные 1: Введите нужное количество пирожков
// Входные данные  1: 2
// Выходные данные 1: 2 пирожков(ка) стоит 11 руб 0 коп

// System.Console.Write("Введите целое число, обозначающие количество рублей: ");
// int rubles = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите целое число, обозначающие количество копеек: ");
// int kopecks = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите нужное количество пирожков: ");
// int food = Convert.ToInt32(Console.ReadLine());
// int cellFood = (rubles * 100 + kopecks) * food;
// System.Console.WriteLine($"{food} пирожков стоят: {cellFood/100} руб {cellFood%100} коп");

// Написать программу для вычисления введенного число x в 6 степени
// при помощи трех операций умножения.
// Пример использования:
// Выходные данные 1: Введите целое число
// Входные данные  1: 3
// Выходные данные 1: 3 в шестой степени = 729

// System.Console.Write("Введите целое число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = 1;
// result = number * number;
// result = result * result * result;
// System.Console.WriteLine($"{number} в шестой степени = {result}");

//Home_11. Дана сторона квадрата. Найти его периметр.
// System.Console.Write("Введите длину стороны квадрата: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int perimetr = 4 * a;
// System.Console.WriteLine($"Периметр квадарата = {perimetr}");

// Home_12. Дано с клавиатуры целое число x. Пользуясь только операцией умножения, получить:
// а) x^4 за две операции; 16
// б) x^6 за три операции; 64
// в) x^7 за четыре операции; 128
// г) x^8 за три операции;
// д) x^9 за четыре операции;
// е) x^10 за четыре операции;
// ж) x^13 за пять операций;
// з) x^15 за пять операций;
// и) x^21 за шесть операций;
// к) x^28 за шесть операций;
// л) x^64 за шесть операций.
//System.Console.Write("Введите целое число: ");
//int x = Convert.ToInt32(Console.ReadLine());
// а) x^4 за две операции; 16
// x=x*x; x=x*x;
// System.Console.WriteLine($"2 в 4 степени = {x}");
//б) x^6 за три операции; 64
// x=x*x; x=x*x*x;
// System.Console.WriteLine($"2 в 6 степени = {x}");
// в) x^7 за четыре операции; 128
// int result = 1;
// result = x * x * x;
// result = result * result;
// result = result * x;
// System.Console.WriteLine($"{x} в 7 степени = {result}");
// г) x^8 за три операции; 256
// int result = 1;
// result = x * x;
// result = result * result;
// result = result * result;
// System.Console.WriteLine($"{x} в 8 степени = {result}");
//д) x^9 за четыре операции; 512
// int result = 1;
// result = x * x;
// result = result * result;
// result = result * result;
// result = result * x;
// System.Console.WriteLine($"{x} в 9 степени = {result}");
// е) x^10 за четыре операции; 1024
// int result = 1;
// int y = 1;
// result = x * x;
// y = result * result;
// y = y * y;
// result = result * y;
// System.Console.WriteLine($"{x} в 10 степени = {result}");
// ж) x^13 за пять операций; 8192
// int result = 1;
// result = x * x;
// result = result * result * result;
// result = result * result;
// result = result * x;
// System.Console.WriteLine($"{x} в 13 степени = {result}");
// з) x^15 за пять операций; 32768
// int result = 1;
// int y = 1;
// result = x * x * x;
// y = result * result;
// y = y * y;
// result = result * y;
// System.Console.WriteLine($"{x} в 15 степени = {result}");
// и) x^21 за шесть операций; 2 097 152
// int result = 1;
// int y = 1;
// int z = 1;
// z = x * x * x; //8
// result = z * z; //64
// y = result * result; //4 096
// y = result * z; //32 768
// result = result * y;
// System.Console.WriteLine($"{x} в 21 степени = {result}");
// к) x^28 за шесть операций; 268 435 456
// int result = 1;
// int y = 1;
// y = x * x; //4
// result = y * y;  //16
// y = result * result * result; //4096
// y = y * y;
// result = y * result;
// System.Console.WriteLine($"{x} в 21 степени = {result}");
// Home_12. Дано с клавиатуры целое число x. Пользуясь только операцией умножения, получить:
// л) x^64 за шесть операций.
// System.Console.Write("Введите целое число: ");
// double x = Convert.ToDouble(Console.ReadLine());
// double result = 1;
// result = x * x;
// result = result * result;
// result = result * result;
// result = result * result;
// result = result * result;
// result = result * result;
// System.Console.WriteLine($"{x} в 64 степени = {result}");

// Home_13. Составить программу обмена значениями трех переменных величин
// а, b, c по следующей схеме:
// а) b присвоить значение c, а присвоить значение b, с присвоить значение а;
// б) b присвоить значение а, с присвоить значение b, а присвоить значение с.

// System.Console.Write("Введите значение числа a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите значение числа b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите значение числа c: ");
// int c = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"a = {a} b = {b} c = {c}");
//а) b присвоить значение c, а присвоить значение b, с присвоить значение а
// int temp1 = a;
// a = b;
// //int temp2 = b;
// b = c;
// c = temp1;
// System.Console.WriteLine($"a = {a} b = {b} c = {c}");
//б) b присвоить значение а, с присвоить значение b, а присвоить значение с.
// int temp1 = a;
// a = c;
// c = b;
// b = temp1;
// System.Console.WriteLine($"a = {a} b = {b} c = {c}");

//Home_14. Дана длина ребра куба. Найти объем куба и площадь его боковой поверхности.
// v = a в 3 степени
// s = 2 во 2 степени
// System.Console.Write("Введите длину ребра куба: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Объем куба равен: " + a * a * a);
// System.Console.WriteLine("Площадь боковой поверхности: " + a * a);

// Home_15. Известна стоимость 1 кг конфет, печенья и яблок.
// Найти стоимость всей покупки, если купили x кг конфет, у кг печенья и z кг яблок.
// System.Console.Write("Введите стоимость 1кг конфет: ");
// double priceCandies = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("Введите количество купленных конфет: ");
// double сandies = Convert.ToDouble(Console.ReadLine());

// System.Console.Write("Введите стоимость 1кг печенья: ");
// double priceCookies = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("Введите количество купленных печенья: ");
// double cookies = Convert.ToDouble(Console.ReadLine());

// System.Console.Write("Введите стоимость 1кг яблок: ");
// double priceApples = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("Введите количество купленных яблок: ");
// double apples = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine("Стоимость всей покупки: " + (priceCandies * сandies + 
// priceCookies * cookies + priceApples * apples));

// Home_16. Даны два числа. Найти их сумму, разность, произведение,
// а также частное от деления первого числа на второе.
// System.Console.Write("Введите первое число: ");
// double firstNumber = Convert.ToDouble(Console.ReadLine());

// System.Console.Write("Введите второе число: ");
// double secondNumber = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine("Сумма чисел " + firstNumber + " + " + secondNumber + " = " +
// (firstNumber + secondNumber));
// System.Console.WriteLine("Разность чисел " + firstNumber + " - " + secondNumber + " = " +
// (firstNumber - secondNumber));
// System.Console.WriteLine("Произведение чисел " + firstNumber + " * " + secondNumber + " = " +
// (firstNumber * secondNumber));
// System.Console.WriteLine("Частное от деления чисел " + firstNumber + " / " + secondNumber + " = " +
// Math.Round((firstNumber / secondNumber),1));

// Home_17. Пользователь вводит количество недель, месяцев, лет
// и получает количество дней за это время. Считать, что в месяце 30 дней.