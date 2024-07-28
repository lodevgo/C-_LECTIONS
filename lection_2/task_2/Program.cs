System.Console.WriteLine("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
int i = 0;
while (i < arr.Length)
{
    arr[i] = i + 1;
    // Console.Write(arr[i]);
    // Console.Write(arr[' ']);
    Console.Write($"{arr[i]} ");
    i++;
}