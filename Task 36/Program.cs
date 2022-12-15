// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[10];

int oddsum(int[] arr)
{
    int answer = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) answer += arr[i];
    }
    return answer;
}

Console.Clear();
Console.WriteLine("Задан массив:");

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-99, 100);
    Console.Write($"{array[i]} ");
}

Console.WriteLine();

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {oddsum(array)}");
