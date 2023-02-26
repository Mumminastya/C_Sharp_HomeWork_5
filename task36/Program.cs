// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на 
// нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArrayWithRandomNumbers(int length)
{
int[] arr = new int [length];
Random rnd = new Random();
Console.Write("[");
for(int i =0; i < arr.Length - 1; i++)
{
    arr[i] = rnd.Next(100, 999);
    Console.Write($"{arr[i]}, ");
}

    arr[arr.Length - 1] = rnd.Next(100, 999);
    Console.Write($"{arr[arr.Length - 1]}]");

return arr;
}

int Sum(int[] arr)
{
    int result = 0;
    for(int i = 1; i < arr.Length; i = i + 2)
    {
        result += arr[i];
    }
    return result;
}

int[] arr = FillArrayWithRandomNumbers(10);
Console.WriteLine($" -> {Sum(arr)}");
