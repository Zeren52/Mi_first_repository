 // Задача 3: Напишите программу, которая перевернёт одномерный массив 
 // (первый элемент станет последним, второй – предпоследним и т.д.)
// int[] CreateArrRndInt(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }
// void PrintOut(int[] arr)
// {
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write($"{arr[i]}, ");
//     }
//     Console.Write($"{arr[^1]}");// ^1 последний элемент массива
// }

// void ReverseArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length/2; i++)
//     {
//         int temp = arr[i];
//         arr[i]=arr[arr.Length-i-1];
//         arr[arr.Length-i-1]=temp;
//     }
// }
// int[] array= CreateArrRndInt(5,1,9);
// PrintOut(array);
// Console.WriteLine();
// ReverseArray(array);
// PrintOut(array);


// Задача 2: Задайте массив заполненный случайными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// int[] CreateArrRndInt(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }

//     return arr;
// }

// int CountEvenElements(int[] arr)
// {
//     int positiveCount = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//       if (arr[i]%2==0) positiveCount++;
//     //  Console.WriteLine($"= {arr[i]} - {i} - {arr[i]%2==0} ="); // визуализация проверки на чётность
//     }
//     return positiveCount;
// }

// void PrintOut(int[] arr)
// {   
//     Console.Write("[");
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write($"{arr[i]}, ");
//     }
//     Console.Write($"{arr[^1]}]");// ^1 последний элемент массива
// }
// int[] array = CreateArrRndInt(4,100,1000); //[100..999]
// PrintOut(array);
// Console.WriteLine();
// int countPositiveElements = CountEvenElements(array);
// Console.WriteLine($"Количество чётных чисел в массиве: {countPositiveElements}");

// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли.
//  Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.


while (true) // true == true
{
Console.Write("Введите текст: ");
string text = Console.ReadLine();
if (text == "q")
{
break;
}
// 11 => 1+1 = 2
int number; // n = 0, в text присутствуют не только цифры
// Проверка, что строчка text состоит ТОЛЬКО из цифр
if (int.TryParse(text, out number))// == true
{
int sum = 0; // 56=>5+6 = 11
while (number > 0)
{
sum = sum += 1 ; // sum = 6; здесь исправить!
number /= 10;
}
if (sum % 2 == 0)
{
break;
}
}
}