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
/*
System.Console.Write("Введите количество недель: ");
double countWeek = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите количество месяцев: ");
double countMonth = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Введите количество лет: ");
double countYears = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Количество дней за это время равно: " + (countWeek * 7
 + countMonth * 30 + countYears * 365));
*/
/*
Home_18. Известно значение температуры по шкале Цельсия.
Найти соответствующее значение температуры по шкале:
а) Фаренгейта; С => 33,8 F
б) Кельвина.   C => 274,15 K
*/
/*
System.Console.Write("Введите значение температуры по шкале Цельсия: ");
double C = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Соответствующее значение температуры по шкале Фаренгейта: "
+ C * 33.8 );
System.Console.WriteLine("Соответствующее значение температуры по шкале Кельвина: "
+ C * 274.15 );
*/
/*
Home_19. С начала суток прошло n секунд. Определить:
а) сколько полных часов прошло с начала суток;
б) сколько полных минут прошло с начала очередного часа;
в) сколько полных секунд прошло с начала очередной минуты
*/
/*
System.Console.Write("Введите количество секунд: ");
double second = Convert.ToDouble(Console.ReadLine());
int secondConvert = (int) second;
Console.WriteLine("С начала суток прошло полных часов: "
+ secondConvert / (60 * 60));
Console.WriteLine("С начала очередного часа прошло полных минут: "
+ secondConvert / 60);
Console.WriteLine("С начала очередного часа прошло полных минут: "
+ secondConvert); 
*/
/*
Home_20. Дан прямоугольник с размерами 543х130 мм.
Сколько квадратов со стороной 130 мм можно отрезать от него?
*/
/*
int a = 543;
int b = 130;
System.Console.WriteLine(a/b);
*/
/*
Дано неотрицательное целое число. Найдите число десятков этого числа.
Пример использования:
Выходные данные: Введите целое число
Входные данные : 5143
Выходные данные: Число десятков = 4
*/
/*
Console.WriteLine("Введите целое число");
//int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Число десятков = " + num / 10 % 10);
Console.WriteLine("Число десятков = " + int.Parse(Console.ReadLine()) / 10 % 10);
*/
/*
Дано целое трехзначное число. Необходимо найти сумму его цифр.
Пример использования:
Выходные данные: Введите целое трехзначное число
Входные данные : 213
Выходные данные: Сумма цифр числа = 6
*/
/*
System.Console.Write("Введите целое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Сумма цифр числа = " + (number / 100 + number / 10 % 10
+ number % 10));
*/
/*
Дано целое не отрицательное трехзначное число. Переверните число и выведите.
Пример использования:
Выходные данные: Введите целое трехзначное число
Входные данные : 123
Выходные данные: Перевернутое число 123 = 321
*/
/*
System.Console.Write("Введите целое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Перевернутое число " + number + " = " + number % 10
+ number / 10 % 10 + number / 100);
*/
/*
Дано целое шестизначное число. Найдите сумму его первых трех цифр.
Пример использования:
Выходные данные 1: Введите целое шестизначное число
Входные данные  1: 654023
Выходные данные 1: Сумма последних трех цифр числа = 15
*/
/*
System.Console.Write("Введите целое шестизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Сумма первых трех цифр числа = " + (number / 100000
+ number / 10000 % 10 + number / 1000 % 10));
*/
/*
Home_21. Дано трехзначное число. Найти:
а) число единиц в нем;
б) число десятков в нем;
в) сумму его цифр;
г) произведение его цифр.
Решить в одной программе.
*/
/*
System.Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Число единиц в числе " + number + " = " + number % 10);
System.Console.WriteLine("Число десятков в числе " + number + " = " + number / 10 % 10);
System.Console.WriteLine("Сумма цифр числа " + number + " = " 
+ (number / 100 + number / 10 % 10 + number % 10));
System.Console.WriteLine("Произведение цифр числа " + number + " = " 
+ (number / 100 * number / 10 % 10 * number % 10));
*/
/*
Home_22. Дано трехзначное число.
а) Найти число, полученное при прочтении его цифр справа налево.
б) В нем зачеркнули первую слева цифру и приписали ее в конце. Найти полученное число.
в) В нем зачеркнули последнюю справа цифру и приписали ее в начале. Найти полученное число.
г) Найти число, полученное при перестановке первой и второй цифр заданного числа.
д) Найти число, полученное при перестановке второй и третьей цифр заданного числа.
Решить в одной программе.
*/
/*
System.Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
//а) Найти число, полученное при прочтении его цифр справа налево.
System.Console.WriteLine("а) = " + number % 10 + number / 10 % 10 + number / 100);
//б) В нем зачеркнули первую слева цифру и приписали ее в конце. Найти полученное число.
System.Console.WriteLine("б) = " + number / 10 % 10 + number % 10 + number / 100);
//в) В нем зачеркнули последнюю справа цифру и приписали ее в начале. Найти полученное число.
System.Console.WriteLine("в) = " + number % 10 + number / 100 + number / 10 % 10);
//г) Найти число, полученное при перестановке первой и второй цифр заданного числа.
System.Console.WriteLine("г) = " + number / 10 % 10 + number / 100 + number % 10);
//д) Найти число, полученное при перестановке второй и третьей цифр заданного числа.
System.Console.WriteLine("д) = " + number / 100 + number % 10 + number / 10 % 10);
*/
/*
Home_23. Дано трехзначное число, в котором все цифры различны.
Получить шесть чисел, образованных при перестановке цифр заданного числа.
*/
/*
Home_24. Из трехзначного числа x вычли его последнюю цифру.
Когда результат разделили на 10, а к частному слева приписали последнюю цифру числа x,
то получилось число 237. Найти число x.
*/
/*
int c = 2;
System.Console.WriteLine("c = 2; x = abc - c = ab; ab / 10 = 37; ab = 370; x = " + (370 + c));
*/
/*
Home_25. В трехзначном числе x зачеркнули первую цифру.
Когда оставшееся число умножили на 10, а произведение сложили
с первой цифрой числа x, то получилось число 564. Найти число x.
*/
//456
/*Home_26. В трехзначном числе x зачеркнули его вторую цифру.
Когда к образованному при этом двузначному числу слева приписали вторую цифру числа x,
то получилось число 546. Найти число x.
*/
//456
/*
Home_27. В трехзначном числе x зачеркнули его последнюю цифру.
Когда в оставшемся двузначном числе переставили цифры,
а затем приписали к ним слева последнюю цифру числа x, то получилось число 654.
Найти число x.
*/
//456
/*
Даны два числа, которые вводятся в консоль построчно.
Вывести в консоль их среднее арифметическое.
Пример использования:
Выходные данные 1: Введите построчно два числа
Входные данные  1: (1) (3)
Выходные данные 1: Среднее арифметическое введенных чисел = 2
*/
/*
System.Console.WriteLine("Введите 2 числа");
System.Console.WriteLine("Среднее арифметическое введенных чисел = "
+ (Convert.ToDouble(Console.ReadLine()) + Convert.ToDouble(Console.ReadLine())) / 2);
*/
/*
Дано положительное действительное число x.
Выведите его дробную часть не используя приведения и методы класса Math.
Пример использования:
Выходные данные 1: Введите вещественное число
Входные данные  1: 7.938
Выходные данные 1: Дробная часть числа = 0.938
*/
/*
System.Console.Write("Введите вещественное число: ");
double number = Convert.ToDouble(Console.ReadLine());
// int numberInt = (int) (number);
// System.Console.WriteLine("Дробная часть числа " + number + " = " + (number - numberInt));
System.Console.WriteLine("Дробная часть числа " + number + " = " + number % 1);
*/
/*
Дано положительное действительное число x. Выведите его первую цифру после десятичной точки.
Пример использования:
Выходные данные: Введите действительное число с дробью
Входные данные : 15.89
Выходные данные: первая цифра в дроби - 8
*/
/*
System.Console.Write("Введите положительное действительное число: ");
double number = Convert.ToDouble(Console.ReadLine());
double result = number * 10;
int x = (int) (result);
System.Console.WriteLine("первая цифра в дроби - " + x % 10);
*/
/*
Home_28. Известны объем и масса тела. Определить плотность материала этого тела.
*/
//р = m/V
/*
System.Console.Write("Введите объем тела, м3: ");
double V = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите массу тела, кг: ");
double m = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("плотность материала этого тела = " + m / V + " кг/м3");
*/
/*
Home_29. Известны количество жителей в государстве и площадь его территории.
Определить плотность населения в этом государстве.
*/
//П. н. = P / Q, где P – численность постоянного населения территории;
// Q – площадь территории без учёта крупных внутр. водных бассейнов.
/*
System.Console.Write("Введите кол-во жителей в государстве, чел.: ");
double P = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите площадь территории государства, м2: ");
double Q = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("плотность населения в этом государстве = " + P / Q + " чел/м2");
*/
/*
Home_30a. Написать консольное приложение для нахождения диаметра,
длины окружности, площади круга, при введенном радиусе.
*/
/*
System.Console.Write("Введите радиус круга, см.: ");
double radius = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("диаметр круга = " + 2 * radius + " см");
// С = 2pr
System.Console.WriteLine("длина окружности = " + Math.Round(2 * 3.14 * radius,2) + " см");
// S = pr^2
System.Console.WriteLine("Площадь круга = " +  3.14 * radius * radius + " см^2");
*/
/*
Home_30b. Написать консольное приложение для нахождения периметра и площади
прямоугольного треугольника, при введенных построчно длинах сторон треугольника.
*/
// P = a + b + c
// S = a * b / 2
/*
System.Console.Write("Введите длину стороны (a) прямоугольного треугольника, см.: ");
double a = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите длину стороны (b) прямоугольного треугольника, см.: ");
double b = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите длину стороны (c) прямоугольного треугольника, см.: ");
double c = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Периметр прямоугольного треугольника = " + (a + b + c) + " см");
System.Console.WriteLine("Площадь прямоугольного треугольника = " + (a * b / 2) + " см^2");
*/
