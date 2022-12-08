// (Методы в конце)



// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];

FillDoubleArray(array);
Console.WriteLine();
PrintArray(array);











// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.Write("Введите кол-во строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

FillArray(array);
Console.WriteLine();
PrintArray(array);
 
Console.Write("Введите порядковый номер строки искомого элемента:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите порядковый номер столбца искомого элемента:");
int b = Convert.ToInt32(Console.ReadLine());
 
if (a < 1 || b < 1) 
{
    Console.WriteLine("Такого положения нет");
    Console.WriteLine();
}

if (a>m && b>n)
{
    Console.WriteLine("Такого числа нет");
}
else
{
    Console.WriteLine($"Значение искомого элемента: {array[a-1, b-1]}");
}










// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] array = new int[new Random().Next(1, 10), new Random().Next(1, 10)];

Console.WriteLine("Рандомный массив: ");
FillAndPrintArraySmall(array);

Console.WriteLine($"Кол-во строк: {array.GetLength(0)}");
Console.WriteLine($"Кол-во столбцов: {array.GetLength(1)}");
Console.WriteLine("Среднее арифметическое каждого столбца: ");

for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.Write($"{ sum / array.GetLength(0)};  ");
}












// Методы
void PrintArray(int[,] matr)
{ 
    for (int i = 0; i < array.GetLength(0); i++)
    { 
        for (int j = 0; j < array.GetLength(1); j++)
        { 
            Console.Write($"{matr[i, j]}    ");
        }
        Console.WriteLine();
    }
}

void FillDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Convert.ToDouble(new Random().Next(-100, 100)/10.0);
        }
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i, j] = Convert.ToInt32(new Random().Next(0,101));  
        }
    }
}

void FillAndPrintArraySmall(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}