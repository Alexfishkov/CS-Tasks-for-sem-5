// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76

int[] array = new int[] {5,14,78,19,56,112,89,22,11,13};

int difference(int[] arr)
{
    int answer = 0;
    int max = arr[0];
    int min = arr[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        else if (arr[i] < min) min = arr[i];
    }
    answer = max - min;
    return answer;
}

Console.Clear();
Console.WriteLine("Задан массив:");

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}

Console.WriteLine();

Console.WriteLine($"Разница между макс и мин элементами массива составляет: {difference(array)}");