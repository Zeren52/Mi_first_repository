int n = 10;
int[] array = { 2, 5, 34, 565, 35, 76, 23, 14, 24, 245 };
int i = 0;

while (i < n)
{
    if(array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i = i + 1;
}
