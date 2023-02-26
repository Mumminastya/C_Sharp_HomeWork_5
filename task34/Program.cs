// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

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

int EvenCount(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
     if(arr[i] % 2 == 0)
        {
            count ++;
        }
    }
    return count;
}

int [] r2d2 = FillArrayWithRandomNumbers(10);
Console.WriteLine($" -> {EvenCount(r2d2)}");
