// 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] FillArrayWithRandomNumbers(int length)
{
double[] arr = new double [length];
Random rnd = new Random();
Console.Write("[");
for(int i =0; i < arr.Length - 1; i++)
{
    arr[i] = rnd.Next(0, 999) * rnd.NextDouble();
    arr[i] = Math.Round(arr[i], 2);
    Console.Write($"{arr[i]}, ");
}

    arr[arr.Length - 1] = rnd.Next(0, 999)* rnd.NextDouble();
    arr[arr.Length - 1] = Math.Round(arr[arr.Length - 1], 2);
    Console.Write($"{arr[arr.Length - 1]}]");

return arr;
}

double MinMaxDif (double[] arr)
{
    double min = double.MaxValue;
    double max = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max-min;
}

double[] arr = FillArrayWithRandomNumbers(10);
Console.WriteLine($" -> {MinMaxDif(arr)}");