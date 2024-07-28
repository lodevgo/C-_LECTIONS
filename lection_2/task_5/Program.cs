// int[] arr = { 1, 2, 3, 4, 5};
// for (int i = 0; i < arr.Length; i++)
// {
//     Console.Write($"{arr[i]} ");
// }

// int n = 123;
// int sum = 0;
// for (int i = 0; i < n; i++)
// {
//     sum+= i;
// }
// Console.WriteLine(sum);

int[] array = { 1, 2, 3, 4, 5};
foreach (int e in array)
{
    Console.Write(e);
    e = 0; // Error
}
    