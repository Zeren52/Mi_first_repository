// using System;
// using System.Reflection.Metadata.Ecma335;

// public class Answer {
    
//   static int FindMax(int a, int b, int c)
//     {
//      int max = a;
// if (b > max)
// {
//     max = b;
// }
//  if (c > max)
// {
//     max = c;
// }
// return max;
//     }


//   // Не удаляйте и не меняйте метод Main! 
//   static public void Main(string[] args) {
//         int a, b, c;

//         if (args.Length >= 3) {
//            a = int.Parse(args[0]);
//            b = int.Parse(args[1]);
//            c = int.Parse(args[2]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//            a = 5;
//            b = 6;
//            c = 7;
//         }

//         // Не удаляйте строки ниже
//         int result = FindMax(a, b, c);
//         System.Console.WriteLine($"{result}");
//     }
// }

// using System;

// class Answer {
//     static void CheckIfEven(int number)
//     {
//       // Введите свое решение ниже
//     if (number % 2 ==0)
//     {
//         Console.WriteLine("Число " + "`" + number + "`" + "чётное");
//     }
//     else
//     {
//        Console.WriteLine("Число " + "`" + number + "`" + "нечётное"); 
//     }

//     }
  

//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 6;
//         }

//         // Не удаляйте строки ниже
//         CheckIfEven(number);
//     }
// }

using System;

public class Answer {
    static void PrintEvenNumbers(int number)
    {
      // Введите свое решение ниже
    for (int i = 2; i <= number; i+= 2)
    {
        Console.WriteLine($"{i}\t");
    }

    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 6;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
}