// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.

Console.WriteLine("введите количество строк массива:");
int line = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите количество столбцов массива:");
int column = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[line, column];

for (int i = 0; i < matrix.GetLength(0); i++) 
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[i, j] = Convert.ToInt32(new Random().Next(0, 20));  
}

for (int i = 0; i < matrix.GetLength(0); i++) 
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        Console.Write(matrix[i, j] + "\t  ");
    Console.WriteLine();
}

Console.WriteLine("введите index элемента:");
int lineindex = Convert.ToInt32(Console.ReadLine());
int columnindex = Convert.ToInt32(Console.ReadLine());

if (lineindex >= line || columnindex >= column)
    Console.WriteLine("такого элемента нет");
else
{
    int element = (int)matrix.GetValue(lineindex, columnindex);
    Console.WriteLine($"ваш элемент: {element}");
}