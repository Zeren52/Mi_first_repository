// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да 
// тип данных[] имя_массива = элементы массива или new int[]



int[] array = { 11, 22, 33, 44, 55, 66, 77 }; // new int[7] - генерация памяти для 7 элементов массива
 Console.Write("Введите число для поиска: ");

 int numberForSearch = Convert.ToInt32(Console.ReadLine());
 //bool isFould = false; // Число не найдено
 string resultofSearch = "не найден";
// точка старта; условие- length - длинна;
for(int i = 0; i < array.Length; i++)
{
    if (numberForSearch == array[i])
    {
        resultofSearch = "найден";
        break;
    }
}
Console.WriteLine($"Элемент {numberForSearch}: {resultofSearch}");
//{
    // (numberForSearch == array[0])
    // (numberForSearch == array[1])
    // (numberForSearch == array[2])
//     if (numberForSearch == array[i])
//     {
//         isFould = true; // число найдено
//         break;// ломаем цикл, если нашли число в массиве
//     }
    
// }
// if (isFould)//isFould = true;
// {
//     Console.WriteLine("Да");
// }
// else// isFould = false;
// {
//     Console.WriteLine("Нет");
// }