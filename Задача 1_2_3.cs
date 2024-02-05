// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// int m = InputNumbers("Введите m: ");
// int n = InputNumbers("Введите n: ");
// int functionAkkerman = Ack(m, n);
// Console.Write($"Функция Аккермана = {functionAkkerman} ");
// int Ack(int m, int n)
// {
//   if (m == 0) return n + 1;
//   else if (n == 0) return Ack(m - 1, 1);
//   else return Ack(m - 1, Ack(m, n - 1));
// }
// int InputNumbers(string input) 
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }


// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// GetNumbersMToN(m, n);
// void GetNumbersMToN(int m, int n)
// {
//   int res = m;
//   if (m > n)
//     return;
//   else
//   {
//     Console.WriteLine(m);
//     GetNumbersMToN(m + 1, n);

//   }
// }

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
void GetReversArray_aux(int[] numbers, int i)
{
  if (i >= numbers.Length) return;
  GetReversArray_aux(numbers, i + 1);
  Console.WriteLine(numbers[i]);
}
void GetReversArray(int[] numbers)
{
  GetReversArray_aux(numbers, 0);

}
GetReversArray (new int[] {7, 2, 4, 6, 5, 8, 9, 1, 3});

