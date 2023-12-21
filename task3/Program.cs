int[,] array = new int[,]
{
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
};

int minRowSum = int.MaxValue;
int minRowIdx = -1;

for (int rowIndex = 0; rowIndex < array.GetLength(0); rowIndex++)
{
    int currentRowSum = 0;
    for (int colIndex = 0; colIndex < array.GetLength(1); colIndex++)
    {
        currentRowSum += array[rowIndex, colIndex];
    }

    if (currentRowSum < minRowSum)
    {
        minRowSum = currentRowSum;
        minRowIdx = rowIndex;
    }
}

if (minRowIdx != -1)
{
    int rowLength = array.GetLength(1);
    int[] row = new int[rowLength];

    for (int colIndex = 0; colIndex < rowLength; colIndex++)
    {
        row[colIndex] = array[minRowIdx, colIndex];
    }

    Console.WriteLine($"cтрока с наименьшей суммой элементов: {string.Join(", ", row)}");
}