// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных. 

int[,] GenerateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
int[] MatrixToArray(int[,] matrix)
{
    int[] result = new int[matrix.Length];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            result[count++] = matrix[i, j];

        }
    }
    return result;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}   |");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("   |");
    }
    Console.WriteLine();
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

void GetSameCountNumbers(int[] arr)
{
    int temp = arr[0];
    int count = 1;
    for (int i = 1; i < arr.Length; i++)
    {

        if (temp == arr[i]) count++;
        else
        {
            Console.WriteLine($"{temp} - {count}");
            temp = arr[i];
            count = 1;
        }
    }
    Console.WriteLine($"{temp} - {count}");
}




int[,] matrix = GenerateMatrix(4, 4, 0, 10);
PrintMatrix(matrix);
int[] array = MatrixToArray(matrix);
Array.Sort(array);
PrintArray(array);
GetSameCountNumbers(array);