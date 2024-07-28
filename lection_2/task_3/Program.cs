// Код вывода четных элементов массива
// int n = 10;
// код проверки массива на четность
int[] array = { 2, 5, 5, 10, 12, 14, 15, 17, 18, 10 };
int i = 0;

while (i < array.Length)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
        // Console.Write(array[i]);
        // Console.Write(" ");
    }
    i++;
}