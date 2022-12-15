// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int [] array = new int [123];

int within (int [] arr)
{
    int answer = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (arr[i]>=10 && arr[i]<=99) answer++;
    }
    return answer;
}

Console.Clear();
Console.WriteLine("Задан массив:");

for (int i=0; i<array.Length; i++)
{
    array[i] = new Random().Next(0,151);
    Console.Write($"{array[i]} ");
}

Console.WriteLine();

Console.WriteLine($"Кол-во элементов массива, значения которых лежат в отрезке [10,99]: {within(array)}");