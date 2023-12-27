// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет
// ctrl + /

// int number = 6;
// int result = number * number;
// Возведение в квадкрат;
// string stringNumber = Console.ReadLine();
// Console.WriteLine(stringNumber + 1000);
// Конкатенация - процесс сложения строк
// "1000 + привет" = "1000привет"
// Convert.ToInt32("123") => 123 + 200 = 323 - конвертирование данных, перевели число из строки в привычный формат int
// Строковый тип данных можно конвертировать в любой тип данных при необходимости!
// int = int Console.ReadLine - получает строчку
// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(number + 1000);



Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
// 5 == 5 (trye), 4 == 5 (false) чтобы сравнить два числа используем два знака равно "==" - проверка условий, "=" - int а = 5 используем чтобы положить значение в переменную
if (firstNumber == secondNumber * secondNumber)
// Является ли первое число квадратом второго? Перед фигурными скобками никогда не ставится точка с запятой
{
    // firstNumber = 25, secondNumber = 5
    Console.WriteLine("Да," + firstNumber + " Является квадратом от " + secondNumber);
    // Да, 25 является квадратом от 5
}
else //  первое число НЕ является квадратом от второго
{
Console.WriteLine("Нет," + firstNumber + " не является квадратом от " + secondNumber);
}