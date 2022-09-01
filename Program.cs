//Задайте двумерный массив размером m x n заполненный случайными вещественными числами

/*
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк: ");
int columns = Convert.ToInt32(Console.ReadLine());

var random = new Random();

double [,] GetArray (int m, int n)
{
     double [,] matrix = new double[m,n];
     for (int i = 0; i < matrix.GetLength(0); i++)     
     {

          for (int j = 0; j < matrix.GetLength(0); j++)
          {
            matrix[i, j] = random.NextDouble();
          }
     }
     return matrix;
}
double[,] result = GetArray(rows, columns);

void PrintArray (double [,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++)
        {
             Console.Write(inputMatrix[i,m] + "\t");
        }
    Console.WriteLine();
    }
}
PrintArray(result);



/*
Задача 50. Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
1,7 -> такого числа в массиве нет (1 строчка, 7 столбец)
*/
/*
int Rows = 8;
int Columns = 8;
var random = new Random();

Console.WriteLine("Введите позицию элемента строки");
int elemenRow = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите позицию элемента столбца");
int elementColumn = Convert.ToInt32(Console.ReadLine());

int[,] FillMatrixArray(int Row, int Column)
{
    int[,] matrixArray = new int[Row, Column];
    for (int i = 0; i < matrixArray.GetLength(0); i++)
    {
        for (int j = 0; j < matrixArray.GetLength(1); j++)
        {
            matrixArray[i, j] = random.Next(1, 10);

        }
    }
    return matrixArray;
}

void PrintMatrixArray(int[,] matrixArray)
{
    for (int i = 0; i < matrixArray.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matrixArray.GetLength(1); j++)
        {
            Console.Write(matrixArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void Checked(int[,] matrixArray, int posElemRow, int posElemCol)
{
    if (posElemRow < matrixArray.GetLength(0) && posElemCol < matrixArray.GetLength(1))
    {
        Console.WriteLine($"Да есть такой элемент {matrixArray[posElemRow, posElemCol]}");
    }
    else
    {
        Console.WriteLine($"Нет такого элемента");
    }

}
 
var matrix = FillMatrixArray(Rows, Columns);

PrintMatrixArray(matrix);
Checked(matrix, elemenRow, elementColumn);

*/

/* Задача 52. Задайте двумерный массив из целых чисел.
 Найдите среднее арифметическое элементов в каждом столбце.
 Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int countRows = 3;
int countColumns = 3;
var random = new Random();

int[,] FillMatrixArray(int countRow, int countColumn)
{
    int[,] matrixArray = new int[countRow, countColumn];
    for (int i = 0; i < matrixArray.GetLength(0); i++)
    {
        for (int j = 0; j < matrixArray.GetLength(1); j++)
        {
            matrixArray[i, j] = random.Next(1, 10);

        }
    }
    return matrixArray;
}

void PrintMatrixArray(int[,] matrixArray)
{
    for (int i = 0; i < matrixArray.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matrixArray.GetLength(1); j++)
        {
            Console.Write(matrixArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

double[] FindingAvgElemInMartix(int[,] matrixArray)
{
    double[] avgColumn = new double[matrixArray.GetLength(1)];
    for (int j = 0; j < matrixArray.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrixArray.GetLength(0); i++)
        {
            sum += matrixArray[i, j];
        }
        avgColumn[j] = sum / matrixArray.GetLength(1);
    }
    return avgColumn;

}

var matrixArray = FillMatrixArray(countRows, countColumns);
PrintMatrixArray(matrixArray);
double[] avgColumn = FindingAvgElemInMartix(matrixArray);

foreach (double i in avgColumn)
{
    Console.Write(i + "\t");
}
