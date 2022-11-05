// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
int row = UserInput("Введите количество строк массива: ");
int column = UserInput("Введите количество столбцов массива: ");
double[,] arrayRandomDoubleNumbers = new double[row, column];
FillArray(arrayRandomDoubleNumbers);
PrintArray(arrayRandomDoubleNumbers);

int UserInput(string output)
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int a = new Random().Next(-9, 10);
            int b = new Random().Next(0, 10);
            array[i, j] = Convert.ToDouble($"{a},{b}");
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}