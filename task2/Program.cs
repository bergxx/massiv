int[,] array = new int[,] { 
{ 1, 2, 3 }, 
{ 4, 5, 6 }, 
{ 7, 8, 9 }, 
};

int line = array.GetLength(1);
for (int i = 0; i < line; i++)
{
    int temp = array[0, i];
    array[0, i] = array[array.GetLength(0) - 1, i];
    array[array.GetLength(0) - 1, i] = temp;
}

for (int row = 0; row < array.GetLength(0); row++)
{
    for (int col = 0; col < array.GetLength(1); col++)
    {
        Console.Write(array[row, col] + " ");
    }
    Console.WriteLine();
}