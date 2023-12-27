using System;

public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        // Введите свое решение ниже
      if (firstNumber < secondNumber )
      {
        Console.WriteLine("Первое число " + "`" + firstNumber + "`" + " меньше чем второе число " + "`" + secondNumber + "`");
      }
        else if (secondNumber < firstNumber)
      {
         Console.WriteLine("Первое число" + "`" + firstNumber + "`" + " больше чем второе число " + "`" + secondNumber + "`");
      }
      else if (secondNumber == firstNumber)
      {Console.WriteLine($"Введенные числа равны " + "`" + firstNumber + "`");  
      }
                                              
    }

  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 5;
            secondNumber = 6;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }
}
//  ПЕРВЫЙ СПОСОБ РЕШЕНИЯ!
using System;

public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        if (firstNumber == secondNumber)
        {
            Console.WriteLine($"Введенные числа равны `{firstNumber}`");
        }
        if (firstNumber > secondNumber)
        {
            Console.WriteLine($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");
        }
        if (firstNumber < secondNumber)
        {
            Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
        }
    }

    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
            firstNumber = 5;
            secondNumber = 5;
        }

        CompareNumbers(firstNumber, secondNumber);
    }
}
// ВТОРОЙ СПОСОБ РЕШЕНИЯ!
