// int number = new Random().Next(10, 100);//99+1
// Console.WriteLine($"Целое число из отрезка [10, 99]={number}");
// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if (firstDigit > secondDigit)
// {
//     Console.WriteLine($"наибольшую цифру числа {firstDigit}");
// }
// else
// {
//     Console.WriteLine($"наибольшую цифру числа {secondDigit}");
// }
// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit; //Тернарный оператор альтернатива if
// Console.WriteLine(maxDigit);


// int GetUserInput(string str)
// {
//     Console.WriteLine(str);
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }


// bool DivisionTo(int num, int num1, int num2)
// {
//     return num%num1==0 && num % num2 ==0;
// }

// int number1 = GetUserInput("Enter number");
// bool div7a23 = DivisionTo(number1,7,23);
// Console.WriteLine(div7a23 ? "является кратным": "не является кратным");


// Console.WriteLine("Введите число:" );
// int n = Convert.ToInt32(Console.ReadLine());
// for(int i=1;i<=n;i++)
// {
// if (i >= 0)
// System.Console.Write(i + ","+ "\t" );
// }

int GetUserInput(string str)
{
    Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int Quater(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0; //x ==0 y == 0

}
int xCoordinate = GetUserInput("Ведите х:");
int yCoordinate = GetUserInput("Ведите y:");
int quater = Quater(xCoordinate, yCoordinate);

Console.WriteLine("2|1");
Console.WriteLine("---");
Console.WriteLine("3|4");
string result = quater > 0
                ? $"Указаные коордитаты соотвествуюи четверти {quater}"
                : $"Введены некоректные координаты";
Console.WriteLine(result);