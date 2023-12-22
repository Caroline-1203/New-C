// // Ex 1. Задайте двумерный массив. 
// // Найдите элементы, у которых оба индекса четные. 
// // Замените эти элементы на их квадраты.

// int[,] array = FillArray(3, 5, 1, 10);

// int[,] FillArray(int rows, int columns, int minValue, int MaxValue)
// {
//     int[,] array = new int[rows, columns];
//     Random rand = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int l = 0; l < columns; l++)
//         {
//             array[i, l] = rand.Next(minValue, MaxValue + 1);

//         }
//     }
//     return array;
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// PrintArray(array);

// FindIndex(array);
// PrintArray(array);
// void FindIndex(int[,] matrix)

// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if(i%2 ==0 && j%2 == 0)
//             {
//                 matrix[i,j] = matrix[i,j] * matrix[i,j];
//                 }
//         }
//         Console.WriteLine();
//     }
// }


// Ex 2. Задайте двумерный массив.
// Найдите сумму элементов, находящихся на главной диагонали (с индексом [0,0]; [1,1]...)

// int[,] FillArray(int rows, int columns, int minValue, int MaxValue)
// {
//     int[,] array = new int[rows, columns];
//     Random rand = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int l = 0; l < columns; l++)
//         {
//             array[i, l] = rand.Next(minValue, MaxValue + 1);

//         }
//     }
//     return array;
// }
// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] list = FillArray(5, 5, 0, 10);
// PrintArray(list);

// int SumNumbers(int[,] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int l = 0; l < array.GetLength(1); l++)
//         {
//             if (i == l)
//             {
//                 sum = sum +array[i,l];
//             }
//         }

//     }
//     return sum;
// }
// int sum = SumNumbers(list);
// Console.WriteLine(sum);


// Ex 3. Задайте двумерный массив из целых чисел.
// Сформируйте новый одномерный массив, 
// состоящий из средних арифметических значений по строкам двумерного массива.
// // 


int[,] FillArray(int rows, int columns, int minValue, int MaxValue)
{
    int[,] array = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            array[i, l] = rand.Next(minValue, MaxValue + 1);

        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}


int[,] arr = FillArray(5, 5, 0, 10);
int[] arr_01 = new int[arr.GetLength(0)];
PrintArray(arr);
for (int i = 0; i < arr.GetLength(0); i++)
{ 
    int sum = 0; 
    for (int l = 0; l < arr.GetLength(1); l++)
        {
            sum += arr[i,l];
        }
        arr_01[i] = sum/arr.GetLength(1);
}
Console.WriteLine($"[{String.Join( ", ", arr_01)}]");

