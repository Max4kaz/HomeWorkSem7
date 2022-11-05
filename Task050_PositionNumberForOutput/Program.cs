// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет. 
// Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
Console.WriteLine("Для поиска элемента в двумерном массиве");
int numberRow = UserInput("введите номер его строки: ");
int numberColumn = UserInput("введите номер его столбца: ");
Console.WriteLine();
int[,] checkingArray = new int[3, 4];
FillArray(checkingArray);
PrintArray(checkingArray);

if (numberRow < checkingArray.GetLength(0) && numberColumn < checkingArray.GetLength(1))
    Console.WriteLine($"Искомый элемент: {checkingArray[numberRow, numberColumn]}");
else
    Console.WriteLine($"Элемента с номером строки {numberRow} и номером столбца {numberColumn} в массиве нет");
    
int UserInput(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] array)
{
    Console.WriteLine("Проверяемый массив:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
