void Zadacha54()
{
/* Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива */

    int rows = 4;
    int columns = 4;
    int [,] numbers = new int [rows,columns];

    FillArray(numbers,0,9);
    PrintArray(numbers);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns-1; j++)
        {
            for (int j1 = 0; j1 < columns-1; j1++)
            {
                if(numbers[i,j1]<numbers[i,j1+1])
                {
                    (numbers[i,j1],numbers[i,j1+1]) = (numbers[i,j1+1],numbers[i,j1]);
                }
            }
        }
    }
    Console.WriteLine("  ");
    Console.WriteLine("Вывод массива:");
    Console.WriteLine("  ");
    PrintArray(numbers);


}

void Zadacha56()
{
   /*  Задача 56: Задайте прямоугольный двумерный массив. Напишите
    программу, которая будет находить строку с наименьшей суммой элементов. */

    int rows = 4;
    int columns = 4;
    int [,] numbers = new int [rows,columns];

    FillArray(numbers,0,9);
    PrintArray(numbers);
    
    int [] mas = new int [rows];
    int index = 0;


    for (int i = 0; i < rows; i++)
    {
        int sum=0;
        for (int j = 0; j < columns; j++)
        {
            sum= sum + numbers[i,j];
        }
        Console.WriteLine(" ");
        Console.WriteLine($"Вывод суммы строки {i+1}: {sum}");        
        Console.WriteLine(" ");
        mas[index] = sum;
        index++;
    }
    Console.WriteLine($"Минимальная сумма {mas.Min()}");

}

void FillArray(int [,] numbers, int minValue, int maxValue)
{
    maxValue++;
    Random rand = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i,j] = rand.Next(minValue,maxValue);
        }
    }
}

void PrintArray(int [,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{numbers[i,j]}\t");
        }
    Console.WriteLine(" ");
    }
}

//Zadacha54();
Zadacha56();