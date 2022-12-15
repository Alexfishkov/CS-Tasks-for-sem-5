// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] array = new int [20];

int even (int [] arr)
{
    int answer = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (arr[i]%2==0) answer++;
    }
    return answer;
}

Console.Clear();
Console.WriteLine("Задан массив:");

for (int i=0; i<array.Length; i++)
{
    array[i] = new Random().Next(100,1000);
    Console.Write($"{array[i]} ");
}

Console.WriteLine();

Console.WriteLine($"В нём содержится {even(array)} чётных чисел");

