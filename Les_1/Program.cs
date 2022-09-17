// Удалить строку и столбец массива с наименьшим значением элемента
int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            result[i, j] = new Random().Next(1, 100);
        }
    }

    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); ++i)
    {
        for (int j = 0; j < array.GetLength(1); ++j)
        {
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();

    }
}



Console.WriteLine(" Vvedtite kolvo strok");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine(" Vvedtite kolvo stolbcov");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();

int minRow = 0;
int minColumn = 0;
int minEl = array[0, 0];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        if (minEl > array[i, j])
        {
            minEl = array[i, j];
            minRow = i;
            minColumn = j;
        }
    }
}

Console.WriteLine(minRow + "    " + minColumn);

int[,] dest = new int[rows - 1, columns - 1];
int k = 0;
int l = 0;

for (int i = 0; i < rows; i++)
{
    if (i == minRow)
    {
        continue;
    }
    for (int j = 0; j < columns; j++)
    {
        if (j == minColumn)
        {
            continue;
        }
        dest[k, l] = array[i, j];
        l++;
    }
    l = 0;
    k++;
}

PrintArray(dest);
