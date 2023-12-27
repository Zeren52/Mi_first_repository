// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 0)
{
    N = N * -1; //  N = -5, N = 5 Пзволяет работать и с отрицательными числами
}
int negativeN = -N; // или N * 1 ; // N = 5, negativeN = N * -1
// N = -2 , negativeN = 2
// 2 <= -2? НЕТ нужно вводить положительное число
Console.WriteLine(negativeN);
while (negativeN <= N)
{
    Console.Write(negativeN + "\t"); 
    negativeN++;
    // "\t" = tab
}
// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
//  [100, 999]
// "&&" - "И": яблоки И апельсины
if(number >= 100 && number <= 999)
{
    Console.Write("Число трёхзначное : ");
    // 167 => 1 + 7
    int thirdDigit = number % 10; // 167 % 10 = 7
    int fhirdDigit = number / 100; // 167 / 100 = 1
    int result = fhirdDigit + thirdDigit;
    Console.WriteLine("Сумма 1 и 3 цифры от числа: " + number + " = " + result);
}
else
{
    Console.Write("Число не трёхзначное : ");
}
// int a = 5
// Буква ё на англ. раскладке
// Console.WriteLine("Значение переменной a:" + "`" + a + "`");