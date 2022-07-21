 
 void Задача47()
 {
 //Задача 47. Задайте двумерный массив размером m×n, заполненный 
 //случайными вещественными числами, округлёнными до одного знака.
 //m = 3, n = 4.
 //0,5 7 -2 -0,2
 //1 -3,3 8 -9,9
 //8 7,8 -7,1 9

 int rows = 3;
 int columns = 4;

 double[,] array = new double[rows, columns];
 Fillarray(array);
 PrintArray(array);

void Fillarray(double[,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
           array[i, j] = Math.Round(random.NextDouble() * 10 - 5, 1);
        }
    } 
}
 

void PrintArray(double[,] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива");
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
           Console.Write(array[i, j] + "\t");      
        }
        Console.WriteLine(); 
    }
       Console.WriteLine();
}

 }


 void Задача50()
 {
 //Задача 50. Напишите программу, которая на вход принимает позиции элемента 
 //в двумерном массиве, и возвращает значение этого элемента или же указание, 
 //что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

 int rows = 3;
 int columns = 4;

 int[,] array = new int[rows, columns];
 Fillarray(array);
 PrintArray(array);

 Console.WriteLine("Введите номер строки искомого элемента");
 int row = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите номер столбца искомого элемента");
 int column = Convert.ToInt32(Console.ReadLine());
 if (row >= 1 && row <= rows && column >= 1 && column <= columns)
{
    Console.WriteLine($"Искомый элемент array[{row}, {column}] = {array[row - 1, column - 1]}");
}
else
{
    Console.WriteLine("Искомый элемент не найден");
}

void Fillarray(int[,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
           array[i, j] = random.Next(0, 10);
        }
    } 
}
void PrintArray(int[,] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива");
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
           Console.Write(array[i, j] + "\t");      
        }
        Console.WriteLine(); 
    }
       Console.WriteLine();
}
 }

 void Задача52()
 {
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
//элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
 int rows = 3;
 int columns = 4;

 int[,] array = new int[rows, columns];
 Fillarray(array);
 PrintArray(array);

 Console.WriteLine("Вывод массива по столбцам");
 for (int j = 0; j < columns; j++)
 {
   double sum = 0;
    for (int i = 0; i < rows; i++)
    {
        sum += array[i, j];  
    }
    double average = sum/rows;
   Console.Write(average + "\t");
 }
  Console.WriteLine(); 

  void Fillarray(int[,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
           array[i, j] = random.Next(0, 10);
        }
    } 
}
void PrintArray(int[,] array)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива");
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
           Console.Write(array[i, j] + "\t");      
        }
        Console.WriteLine(); 
    }
       Console.WriteLine();
}
}

Задача52();
 //Задача50();
//Задача47();