// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)
using System.ComponentModel.DataAnnotations;

int[] array = { 11, 22, 33, 44, 55, 66, 77 };
int[] result = new int[array.Length / 2]; // 7 / 2 = 3
// Массив result, состоящий из 3 элементов: [0,0,0]
for (int i = 0, j = array.Length - 1; i < result.Length; i++, j-- )
{
    result[i] = array[i] * array[j];
}
Console.WriteLine($"Результат: [{string.Join(";", result)}]");