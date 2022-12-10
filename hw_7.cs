
void PrintArrayDoub(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}


void FillArrayDoub(double[,] numbers)
{
    Random rand = new Random();

    int size = numbers.Length;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = rand.Next(1, 20) + Math.Round(rand.NextDouble(), 1);
        }
    }
}


// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака.


void Zadacha47()

{
    int m = 5;
    int n = 4;

    double[,] arr = new double[m, n];

    FillArrayDoub(arr);
    PrintArrayDoub(arr);
}

//Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


void Zadacha50()
{

    int m = 4;
    int n = 4;

    int[,] arr = new int[m, n];

    FillArray(arr);
    PrintArray(arr);

    Console.Write("Введите число a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число b: ");
    int b = Convert.ToInt32(Console.ReadLine());

    if (a < m && b < n)
    {
        Console.WriteLine();
        Console.WriteLine($"Найденный элемент: {arr[a, b]}");
    }
    else
    {
        Console.WriteLine("Введено недопустимое значение");
    }

}


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void Zadacha52()
{
    int m = 5;
    int n = 4;

    int[,] arr = new int[m,n];

    FillArray(arr);
    PrintArray(arr);



    for (int i = 0; i < n; i++)
    {
        double avg = 0;
        double sum = 0;
        
        for (int j = 0; j < m; j++)
        {
            sum = ((sum + arr[j, i]));
        }

        Console.WriteLine();
        avg = sum / m;
        Console.WriteLine(avg);
    }

}
