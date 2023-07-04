/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
*/
#region 
int InputNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double[,] Array2DGeneration(int lines, int colums)
{
    return new double[lines, colums];
} 

void Fill2DArray(double[,] array, int min, int max)
{
    for(int i = 0;  i < array.GetLength(0); i++)
        for(int j  = 0;  j < array.GetLength(1); j++)
            array[i, j] = Math.Round(new Random().NextDouble() * 100, 2);
}

void Print2DArray(double[,] array)
{
    Console.WriteLine();
    for(int i = 0;  i < array.GetLength(0); i++)
    {
        for(int j  = 0;  j < array.GetLength(1); j++)
        
            Console.Write(array[i, j] + "\t");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}

int lines = InputNumber(" Введите длинну строк массива: ");
int colums = InputNumber(" Введите длинну столбцов массива: ");
int minValue = InputNumber(" Введите минимальный элемент: ");
int maxValue = InputNumber(" Введите максимальный элемент: ");

double[,] myArry = Array2DGeneration(lines, colums);
Fill2DArray(myArry, minValue, maxValue);
Print2DArray(myArry);
#endregion
/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
*/
#region 
int InputNumb(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Array2DGener(int lines, int colums)
{
    return new int[lines, colums];
} 

void Fill2DArr(int[,] array)
{
    int min = 1;
    int max = 10;
    for(int i = 0;  i < array.GetLength(0); i++)
        for(int j  = 0;  j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(min, max + 1);
}

void Print2DArr(int[,] array)
{
    Console.WriteLine();
    for(int i = 0;  i < array.GetLength(0); i++)
    {
        for(int j  = 0;  j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Average(int[,] array, int lines)
{
    Console.WriteLine();
    Console.Write(" Срднее арехметическое: ");
    
    for(int j = 0;  j < array.GetLength(1); j++)
    {
        double avg = 0;
        for(int i  = 0;  i < array.GetLength(0); i++)
            avg = avg + array[i, j];
            Console.Write(Math.Round(avg / lines, 2) + "  ");
    }
}

int lines = InputNumb(" Введите длинну строк массива: ");
int colums = InputNumb(" Введите длинну столбцов массива: ");

int[,] myArry = Array2DGener(lines, colums);
Fill2DArr(myArry);
Print2DArr(myArry);
Average(myArry, lines);
#endregion

/*
 Напишите программу, которая на вход принимает позиции элемента в 
 двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
 */
#region 
 int InputNumb(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Array2DGener(int lines, int colums)
{
    return new int[lines, colums];
} 

void Fill2DArr(int[,] array)
{
    int min = 1;
    int max = 100;
    for(int i = 0;  i < array.GetLength(0); i++)
        for(int j  = 0;  j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(min, max + 1);
}

void Print2DArr(int[,] array)
{
    Console.WriteLine();
    for(int i = 0;  i < array.GetLength(0); i++)
    {
        for(int j  = 0;  j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ValueSearch(int[,] array, int indexLines, int indexColums)
{
    if(indexLines > array.GetLength(0) || indexColums > array.GetLength(1))
    {
        Console.WriteLine(" Неверный ввод ");
    }
    else
    {
        Console.WriteLine(" Элемент индекса: " + array[indexLines , indexColums]);
    }
}

int lines = InputNumb(" Введите длинну строк массива: ");
int colums = InputNumb(" Введите длинну столбцов массива: ");
int indexLines = InputNumb(" Введите индекс строки массива: ");
int indexColums = InputNumb(" Введите индекс столбца массива: ");

int[,] myArry = Array2DGener(lines, colums);
Fill2DArr(myArry);
Print2DArr(myArry);
ValueSearch(myArry, indexLines, indexColums);
#endregion
